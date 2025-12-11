Imports System.Text
Imports System.IO
Imports System.Security.Cryptography
Imports Org.BouncyCastle.Asn1
Imports Org.BouncyCastle.Asn1.Pkcs
Imports Org.BouncyCastle.Asn1.X509
Imports Org.BouncyCastle.Crypto
Imports Org.BouncyCastle.Crypto.Generators
Imports Org.BouncyCastle.Crypto.Operators
Imports Org.BouncyCastle.Crypto.Parameters
Imports Org.BouncyCastle.Math
Imports Org.BouncyCastle.OpenSsl
Imports Org.BouncyCastle.Pkcs
Imports Org.BouncyCastle.Security
Imports Org.BouncyCastle.X509
Imports System.Security.Cryptography.X509Certificates

Public Class MainForm
    Private rsaKeyPair As AsymmetricCipherKeyPair
    Private certificate As Org.BouncyCastle.X509.X509Certificate
    Private rsaCrypto As RSA ' For System.Security.Cryptography

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize form
    End Sub

    Private Sub btnGeneratePrivateKey_Click(sender As Object, e As EventArgs) Handles btnGeneratePrivateKey.Click
        Try
            ' Generate RSA key pair
            Dim keyGenerator As New RsaKeyPairGenerator()
            keyGenerator.Init(New KeyGenerationParameters(New SecureRandom(), 2048))
            rsaKeyPair = keyGenerator.GenerateKeyPair()

            ' Convert to System.Security.Cryptography.RSA for native .NET operations
            ConvertBouncyCastleToRSA()

            ' Save private key
            Using sfd As New SaveFileDialog()
                sfd.Filter = "Private Key (*.key)|*.key|All Files (*.*)|*.*"
                sfd.Title = "Save Private Key"
                If sfd.ShowDialog() = DialogResult.OK Then
                    Using writer As New StreamWriter(sfd.FileName)
                        Dim pemWriter As New PemWriter(writer)
                        pemWriter.WriteObject(rsaKeyPair.Private)
                        pemWriter.Writer.Flush()
                    End Using
                    MessageBox.Show("Private Key generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating Private Key: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGeneratePublicKey_Click(sender As Object, e As EventArgs) Handles btnGeneratePublicKey.Click
        Try
            If rsaKeyPair Is Nothing Then
                MessageBox.Show("Please generate Private Key first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Save public key
            Using sfd As New SaveFileDialog()
                sfd.Filter = "Public Key (*.pub)|*.pub|All Files (*.*)|*.*"
                sfd.Title = "Save Public Key"
                If sfd.ShowDialog() = DialogResult.OK Then
                    Using writer As New StreamWriter(sfd.FileName)
                        Dim pemWriter As New PemWriter(writer)
                        pemWriter.WriteObject(rsaKeyPair.Public)
                        pemWriter.Writer.Flush()
                    End Using
                    MessageBox.Show("Public Key saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving Public Key: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGenerateCSR_Click(sender As Object, e As EventArgs) Handles btnGenerateCSR.Click
        Try
            If rsaKeyPair Is Nothing Then
                MessageBox.Show("Please generate Private Key first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Create certificate subject
            Dim subject As String = String.Format("CN={0}, O={1}, OU={2}, L={3}, ST={4}, C={5}",
                                                 txtCommonName.Text,
                                                 txtOrganization.Text,
                                                 txtOrganizationalUnit.Text,
                                                 txtCity.Text,
                                                 txtState.Text,
                                                 txtCountry.Text)

            ' Generate CSR
            Dim subjectDN As New X509Name(subject)
            Dim signatureFactory As New Asn1SignatureFactory("SHA256WithRSA", rsaKeyPair.Private, New SecureRandom())
            Dim csrBuilder As New Pkcs10CertificationRequest(signatureFactory, subjectDN, rsaKeyPair.Public, Nothing, rsaKeyPair.Private)

            ' Save CSR
            Using sfd As New SaveFileDialog()
                sfd.Filter = "Certificate Request (*.csr)|*.csr|All Files (*.*)|*.*"
                sfd.Title = "Save Certificate Request"
                If sfd.ShowDialog() = DialogResult.OK Then
                    Using writer As New StreamWriter(sfd.FileName)
                        Dim pemWriter As New PemWriter(writer)
                        pemWriter.WriteObject(csrBuilder)
                        pemWriter.Writer.Flush()
                    End Using
                    MessageBox.Show("Certificate Request generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating CSR: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGeneratePEM_Click(sender As Object, e As EventArgs) Handles btnGeneratePEM.Click
        Try
            If rsaKeyPair Is Nothing Then
                MessageBox.Show("Please generate Private Key first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Generate self-signed certificate
            certificate = GenerateSelfSignedCertificate()

            ' Save as PEM
            Using sfd As New SaveFileDialog()
                sfd.Filter = "PEM Certificate (*.pem)|*.pem|All Files (*.*)|*.*"
                sfd.Title = "Save PEM Certificate"
                If sfd.ShowDialog() = DialogResult.OK Then
                    Using writer As New StreamWriter(sfd.FileName)
                        Dim pemWriter As New PemWriter(writer)
                        pemWriter.WriteObject(certificate)
                        pemWriter.Writer.Flush()
                    End Using
                    MessageBox.Show("PEM Certificate generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating PEM: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGenerateP12_Click(sender As Object, e As EventArgs) Handles btnGenerateP12.Click
        Try
            If rsaKeyPair Is Nothing OrElse certificate Is Nothing Then
                MessageBox.Show("Please generate Private Key and Certificate first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrEmpty(txtP12Password.Text) Then
                MessageBox.Show("Please enter P12 password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Create PKCS12 store
            Dim store As New Pkcs12Store()
            Dim certEntry As New X509CertificateEntry(certificate)
            store.SetCertificateEntry(txtCommonName.Text, certEntry)

            Dim keyEntry As New AsymmetricKeyEntry(rsaKeyPair.Private)
            store.SetKeyEntry(txtCommonName.Text, keyEntry, New X509CertificateEntry() {certEntry})

            ' Save as P12
            Using sfd As New SaveFileDialog()
                sfd.Filter = "PKCS#12 Certificate (*.p12;*.pfx)|*.p12;*.pfx|All Files (*.*)|*.*"
                sfd.Title = "Save P12 Certificate"
                If sfd.ShowDialog() = DialogResult.OK Then
                    Using stream As New FileStream(sfd.FileName, FileMode.Create)
                        store.Save(stream, txtP12Password.Text.ToCharArray(), New SecureRandom())
                    End Using
                    MessageBox.Show("P12 Certificate generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating P12: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGenerateCER_Click(sender As Object, e As EventArgs) Handles btnGenerateCER.Click
        Try
            If certificate Is Nothing Then
                MessageBox.Show("Please generate Certificate first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Save as CER (DER format)
            Using sfd As New SaveFileDialog()
                sfd.Filter = "Certificate (*.cer)|*.cer|All Files (*.*)|*.*"
                sfd.Title = "Save CER Certificate"
                If sfd.ShowDialog() = DialogResult.OK Then
                    File.WriteAllBytes(sfd.FileName, certificate.GetEncoded())
                    MessageBox.Show("CER Certificate generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating CER: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GenerateSelfSignedCertificate() As Org.BouncyCastle.X509.X509Certificate
        ' Create certificate subject
        Dim subject As String = String.Format("CN={0}, O={1}, OU={2}, L={3}, ST={4}, C={5}",
                                             txtCommonName.Text,
                                             txtOrganization.Text,
                                             txtOrganizationalUnit.Text,
                                             txtCity.Text,
                                             txtState.Text,
                                             txtCountry.Text)

        Dim subjectDN As New X509Name(subject)
        Dim issuerDN As New X509Name(subject)
        Dim serialNumber As BigInteger = BigInteger.ValueOf(DateTime.Now.Ticks)

        Dim certGen As New X509V3CertificateGenerator()
        certGen.SetSerialNumber(serialNumber)
        certGen.SetIssuerDN(issuerDN)
        certGen.SetSubjectDN(subjectDN)
        certGen.SetNotBefore(DateTime.Now.AddDays(-1))
        certGen.SetNotAfter(DateTime.Now.AddYears(CInt(txtValidityYears.Text)))
        certGen.SetPublicKey(rsaKeyPair.Public)

        Dim signatureFactory As New Asn1SignatureFactory("SHA256WithRSA", rsaKeyPair.Private, New SecureRandom())
        Return certGen.Generate(signatureFactory)
    End Function

    Private Sub btnEncryptSHA256_Click(sender As Object, e As EventArgs) Handles btnEncryptSHA256.Click
        Try
            If String.IsNullOrEmpty(txtDataToEncrypt.Text) Then
                MessageBox.Show("Please enter data to hash!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' SHA256 Hash
            Using sha256 As SHA256 = SHA256.Create()
                Dim bytes As Byte() = Encoding.UTF8.GetBytes(txtDataToEncrypt.Text)
                Dim hash As Byte() = sha256.ComputeHash(bytes)
                txtHashResult.Text = BitConverter.ToString(hash).Replace("-", "").ToLower()
            End Using

            MessageBox.Show("SHA256 hash generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error hashing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSignData_Click(sender As Object, e As EventArgs) Handles btnSignData.Click
        Try
            If rsaKeyPair Is Nothing Then
                MessageBox.Show("Please generate Private Key first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrEmpty(txtDataToSign.Text) Then
                MessageBox.Show("Please enter data to sign!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Sign data with private key
            Dim dataBytes As Byte() = Encoding.UTF8.GetBytes(txtDataToSign.Text)
            Dim signer = SignerUtilities.GetSigner("SHA256withRSA")
            signer.Init(True, rsaKeyPair.Private)
            signer.BlockUpdate(dataBytes, 0, dataBytes.Length)
            Dim signature As Byte() = signer.GenerateSignature()

            txtSignature.Text = Convert.ToBase64String(signature)
            MessageBox.Show("Data signed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error signing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnVerifySignature_Click(sender As Object, e As EventArgs) Handles btnVerifySignature.Click
        Try
            If rsaKeyPair Is Nothing Then
                MessageBox.Show("Please generate Private Key first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrEmpty(txtDataToVerify.Text) OrElse String.IsNullOrEmpty(txtSignatureToVerify.Text) Then
                MessageBox.Show("Please enter data and signature to verify!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Verify signature with public key (BouncyCastle)
            Dim dataBytes As Byte() = Encoding.UTF8.GetBytes(txtDataToVerify.Text)
            Dim signatureBytes As Byte() = Convert.FromBase64String(txtSignatureToVerify.Text)

            Dim verifier = SignerUtilities.GetSigner("SHA256withRSA")
            verifier.Init(False, rsaKeyPair.Public)
            verifier.BlockUpdate(dataBytes, 0, dataBytes.Length)
            Dim isValid As Boolean = verifier.VerifySignature(signatureBytes)

            If isValid Then
                MessageBox.Show("Signature is VALID!", "Verification Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Signature is INVALID!", "Verification Result", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error verifying signature: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' New method: Verify signature using System.Security.Cryptography from CER file
    Private Sub btnVerifySignatureCrypto_Click(sender As Object, e As EventArgs) Handles btnVerifySignatureCrypto.Click
        Try
            If String.IsNullOrEmpty(txtDataToVerify.Text) OrElse String.IsNullOrEmpty(txtSignatureToVerify.Text) Then
                MessageBox.Show("Please enter data and signature to verify!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Open file dialog to select CER certificate
            Using ofd As New OpenFileDialog()
                ofd.Filter = "Certificate Files (*.cer;*.crt;*.pem)|*.cer;*.crt;*.pem|All Files (*.*)|*.*"
                ofd.Title = "Select Certificate File"

                If ofd.ShowDialog() <> DialogResult.OK Then
                    Return
                End If

                ' Load certificate from file
                Dim cert As New X509Certificates.X509Certificate2(ofd.FileName)

                ' Get RSA public key from certificate
                Dim rsaPublicKey As RSA = cert.GetRSAPublicKey()

                If rsaPublicKey Is Nothing Then
                    MessageBox.Show("Certificate does not contain an RSA public key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Verify signature using System.Security.Cryptography
                Dim dataBytes As Byte() = Encoding.UTF8.GetBytes(txtDataToVerify.Text)
                Dim signatureBytes As Byte() = Convert.FromBase64String(txtSignatureToVerify.Text)

                Dim isValid As Boolean = rsaPublicKey.VerifyData(dataBytes, signatureBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1)

                If isValid Then
                    MessageBox.Show($"Signature is VALID!{Environment.NewLine}Certificate: {cert.Subject}{Environment.NewLine}(System.Security.Cryptography)",
                                  "Verification Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show($"Signature is INVALID!{Environment.NewLine}Certificate: {cert.Subject}{Environment.NewLine}(System.Security.Cryptography)",
                                  "Verification Result", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error verifying signature: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Helper method: Convert BouncyCastle key pair to System.Security.Cryptography.RSA
    Private Sub ConvertBouncyCastleToRSA()
        Try
            Dim privateKey As RsaPrivateCrtKeyParameters = CType(rsaKeyPair.Private, RsaPrivateCrtKeyParameters)
            Dim publicKey As RsaKeyParameters = CType(rsaKeyPair.Public, RsaKeyParameters)

            Dim rsaParams As New RSAParameters()
            rsaParams.Modulus = privateKey.Modulus.ToByteArrayUnsigned()
            rsaParams.Exponent = privateKey.PublicExponent.ToByteArrayUnsigned()
            rsaParams.D = privateKey.Exponent.ToByteArrayUnsigned()
            rsaParams.P = privateKey.P.ToByteArrayUnsigned()
            rsaParams.Q = privateKey.Q.ToByteArrayUnsigned()
            rsaParams.DP = privateKey.DP.ToByteArrayUnsigned()
            rsaParams.DQ = privateKey.DQ.ToByteArrayUnsigned()
            rsaParams.InverseQ = privateKey.QInv.ToByteArrayUnsigned()

            rsaCrypto = RSA.Create()
            rsaCrypto.ImportParameters(rsaParams)
        Catch ex As Exception
            Throw New Exception("Error converting BouncyCastle keys to RSA: " & ex.Message)
        End Try
    End Sub

End Class
