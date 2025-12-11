<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpCertificateInfo = New System.Windows.Forms.GroupBox()
        Me.txtValidityYears = New System.Windows.Forms.TextBox()
        Me.lblValidityYears = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtOrganizationalUnit = New System.Windows.Forms.TextBox()
        Me.lblOrganizationalUnit = New System.Windows.Forms.Label()
        Me.txtOrganization = New System.Windows.Forms.TextBox()
        Me.lblOrganization = New System.Windows.Forms.Label()
        Me.txtCommonName = New System.Windows.Forms.TextBox()
        Me.lblCommonName = New System.Windows.Forms.Label()
        Me.grpFileGeneration = New System.Windows.Forms.GroupBox()
        Me.txtP12Password = New System.Windows.Forms.TextBox()
        Me.lblP12Password = New System.Windows.Forms.Label()
        Me.btnGenerateCER = New System.Windows.Forms.Button()
        Me.btnGenerateP12 = New System.Windows.Forms.Button()
        Me.btnGeneratePEM = New System.Windows.Forms.Button()
        Me.btnGenerateCSR = New System.Windows.Forms.Button()
        Me.btnGeneratePublicKey = New System.Windows.Forms.Button()
        Me.btnGeneratePrivateKey = New System.Windows.Forms.Button()
        Me.grpEncryption = New System.Windows.Forms.GroupBox()
        Me.txtHashResult = New System.Windows.Forms.TextBox()
        Me.lblHashResult = New System.Windows.Forms.Label()
        Me.btnEncryptSHA256 = New System.Windows.Forms.Button()
        Me.txtDataToEncrypt = New System.Windows.Forms.TextBox()
        Me.lblDataToEncrypt = New System.Windows.Forms.Label()
        Me.grpSignature = New System.Windows.Forms.GroupBox()
        Me.btnVerifySignatureCrypto = New System.Windows.Forms.Button()
        Me.txtSignatureToVerify = New System.Windows.Forms.TextBox()
        Me.lblSignatureToVerify = New System.Windows.Forms.Label()
        Me.txtDataToVerify = New System.Windows.Forms.TextBox()
        Me.lblDataToVerify = New System.Windows.Forms.Label()
        Me.btnVerifySignature = New System.Windows.Forms.Button()
        Me.txtSignature = New System.Windows.Forms.TextBox()
        Me.lblSignature = New System.Windows.Forms.Label()
        Me.btnSignData = New System.Windows.Forms.Button()
        Me.txtDataToSign = New System.Windows.Forms.TextBox()
        Me.lblDataToSign = New System.Windows.Forms.Label()
        Me.grpCertificateInfo.SuspendLayout()
        Me.grpFileGeneration.SuspendLayout()
        Me.grpEncryption.SuspendLayout()
        Me.grpSignature.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCertificateInfo
        '
        Me.grpCertificateInfo.Controls.Add(Me.txtValidityYears)
        Me.grpCertificateInfo.Controls.Add(Me.lblValidityYears)
        Me.grpCertificateInfo.Controls.Add(Me.txtCountry)
        Me.grpCertificateInfo.Controls.Add(Me.lblCountry)
        Me.grpCertificateInfo.Controls.Add(Me.txtState)
        Me.grpCertificateInfo.Controls.Add(Me.lblState)
        Me.grpCertificateInfo.Controls.Add(Me.txtCity)
        Me.grpCertificateInfo.Controls.Add(Me.lblCity)
        Me.grpCertificateInfo.Controls.Add(Me.txtOrganizationalUnit)
        Me.grpCertificateInfo.Controls.Add(Me.lblOrganizationalUnit)
        Me.grpCertificateInfo.Controls.Add(Me.txtOrganization)
        Me.grpCertificateInfo.Controls.Add(Me.lblOrganization)
        Me.grpCertificateInfo.Controls.Add(Me.txtCommonName)
        Me.grpCertificateInfo.Controls.Add(Me.lblCommonName)
        Me.grpCertificateInfo.Location = New System.Drawing.Point(9, 10)
        Me.grpCertificateInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.grpCertificateInfo.Name = "grpCertificateInfo"
        Me.grpCertificateInfo.Padding = New System.Windows.Forms.Padding(2)
        Me.grpCertificateInfo.Size = New System.Drawing.Size(300, 236)
        Me.grpCertificateInfo.TabIndex = 0
        Me.grpCertificateInfo.TabStop = False
        Me.grpCertificateInfo.Text = "Certificate Information"
        '
        'txtValidityYears
        '
        Me.txtValidityYears.Location = New System.Drawing.Point(112, 197)
        Me.txtValidityYears.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValidityYears.Name = "txtValidityYears"
        Me.txtValidityYears.Size = New System.Drawing.Size(174, 20)
        Me.txtValidityYears.TabIndex = 13
        Me.txtValidityYears.Text = "1"
        '
        'lblValidityYears
        '
        Me.lblValidityYears.AutoSize = True
        Me.lblValidityYears.Location = New System.Drawing.Point(11, 199)
        Me.lblValidityYears.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblValidityYears.Name = "lblValidityYears"
        Me.lblValidityYears.Size = New System.Drawing.Size(79, 13)
        Me.lblValidityYears.TabIndex = 12
        Me.lblValidityYears.Text = "Validity (Years):"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(112, 168)
        Me.txtCountry.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(174, 20)
        Me.txtCountry.TabIndex = 11
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(11, 171)
        Me.lblCountry.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(46, 13)
        Me.lblCountry.TabIndex = 10
        Me.lblCountry.Text = "Country:"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(112, 140)
        Me.txtState.Margin = New System.Windows.Forms.Padding(2)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(174, 20)
        Me.txtState.TabIndex = 9
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(11, 142)
        Me.lblState.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 8
        Me.lblState.Text = "State:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(112, 111)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(174, 20)
        Me.txtCity.TabIndex = 7
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(11, 114)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 6
        Me.lblCity.Text = "City:"
        '
        'txtOrganizationalUnit
        '
        Me.txtOrganizationalUnit.Location = New System.Drawing.Point(112, 83)
        Me.txtOrganizationalUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOrganizationalUnit.Name = "txtOrganizationalUnit"
        Me.txtOrganizationalUnit.Size = New System.Drawing.Size(174, 20)
        Me.txtOrganizationalUnit.TabIndex = 5
        '
        'lblOrganizationalUnit
        '
        Me.lblOrganizationalUnit.AutoSize = True
        Me.lblOrganizationalUnit.Location = New System.Drawing.Point(11, 85)
        Me.lblOrganizationalUnit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrganizationalUnit.Name = "lblOrganizationalUnit"
        Me.lblOrganizationalUnit.Size = New System.Drawing.Size(99, 13)
        Me.lblOrganizationalUnit.TabIndex = 4
        Me.lblOrganizationalUnit.Text = "Organizational Unit:"
        '
        'txtOrganization
        '
        Me.txtOrganization.Location = New System.Drawing.Point(112, 54)
        Me.txtOrganization.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOrganization.Name = "txtOrganization"
        Me.txtOrganization.Size = New System.Drawing.Size(174, 20)
        Me.txtOrganization.TabIndex = 3
        '
        'lblOrganization
        '
        Me.lblOrganization.AutoSize = True
        Me.lblOrganization.Location = New System.Drawing.Point(11, 57)
        Me.lblOrganization.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrganization.Name = "lblOrganization"
        Me.lblOrganization.Size = New System.Drawing.Size(69, 13)
        Me.lblOrganization.TabIndex = 2
        Me.lblOrganization.Text = "Organization:"
        '
        'txtCommonName
        '
        Me.txtCommonName.Location = New System.Drawing.Point(112, 26)
        Me.txtCommonName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCommonName.Name = "txtCommonName"
        Me.txtCommonName.Size = New System.Drawing.Size(174, 20)
        Me.txtCommonName.TabIndex = 1
        '
        'lblCommonName
        '
        Me.lblCommonName.AutoSize = True
        Me.lblCommonName.Location = New System.Drawing.Point(11, 28)
        Me.lblCommonName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCommonName.Name = "lblCommonName"
        Me.lblCommonName.Size = New System.Drawing.Size(82, 13)
        Me.lblCommonName.TabIndex = 0
        Me.lblCommonName.Text = "Common Name:"
        '
        'grpFileGeneration
        '
        Me.grpFileGeneration.Controls.Add(Me.txtP12Password)
        Me.grpFileGeneration.Controls.Add(Me.lblP12Password)
        Me.grpFileGeneration.Controls.Add(Me.btnGenerateCER)
        Me.grpFileGeneration.Controls.Add(Me.btnGenerateP12)
        Me.grpFileGeneration.Controls.Add(Me.btnGeneratePEM)
        Me.grpFileGeneration.Controls.Add(Me.btnGenerateCSR)
        Me.grpFileGeneration.Controls.Add(Me.btnGeneratePublicKey)
        Me.grpFileGeneration.Controls.Add(Me.btnGeneratePrivateKey)
        Me.grpFileGeneration.Location = New System.Drawing.Point(322, 10)
        Me.grpFileGeneration.Margin = New System.Windows.Forms.Padding(2)
        Me.grpFileGeneration.Name = "grpFileGeneration"
        Me.grpFileGeneration.Padding = New System.Windows.Forms.Padding(2)
        Me.grpFileGeneration.Size = New System.Drawing.Size(262, 236)
        Me.grpFileGeneration.TabIndex = 1
        Me.grpFileGeneration.TabStop = False
        Me.grpFileGeneration.Text = "File Generation"
        '
        'txtP12Password
        '
        Me.txtP12Password.Location = New System.Drawing.Point(90, 164)
        Me.txtP12Password.Margin = New System.Windows.Forms.Padding(2)
        Me.txtP12Password.Name = "txtP12Password"
        Me.txtP12Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtP12Password.Size = New System.Drawing.Size(158, 20)
        Me.txtP12Password.TabIndex = 7
        '
        'lblP12Password
        '
        Me.lblP12Password.AutoSize = True
        Me.lblP12Password.Location = New System.Drawing.Point(11, 167)
        Me.lblP12Password.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblP12Password.Name = "lblP12Password"
        Me.lblP12Password.Size = New System.Drawing.Size(78, 13)
        Me.lblP12Password.TabIndex = 6
        Me.lblP12Password.Text = "P12 Password:"
        '
        'btnGenerateCER
        '
        Me.btnGenerateCER.Location = New System.Drawing.Point(135, 193)
        Me.btnGenerateCER.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerateCER.Name = "btnGenerateCER"
        Me.btnGenerateCER.Size = New System.Drawing.Size(112, 24)
        Me.btnGenerateCER.TabIndex = 5
        Me.btnGenerateCER.Text = "Generate CER"
        Me.btnGenerateCER.UseVisualStyleBackColor = True
        '
        'btnGenerateP12
        '
        Me.btnGenerateP12.Location = New System.Drawing.Point(11, 193)
        Me.btnGenerateP12.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerateP12.Name = "btnGenerateP12"
        Me.btnGenerateP12.Size = New System.Drawing.Size(112, 24)
        Me.btnGenerateP12.TabIndex = 4
        Me.btnGenerateP12.Text = "Generate P12"
        Me.btnGenerateP12.UseVisualStyleBackColor = True
        '
        'btnGeneratePEM
        '
        Me.btnGeneratePEM.Location = New System.Drawing.Point(135, 124)
        Me.btnGeneratePEM.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGeneratePEM.Name = "btnGeneratePEM"
        Me.btnGeneratePEM.Size = New System.Drawing.Size(112, 24)
        Me.btnGeneratePEM.TabIndex = 3
        Me.btnGeneratePEM.Text = "Generate PEM"
        Me.btnGeneratePEM.UseVisualStyleBackColor = True
        '
        'btnGenerateCSR
        '
        Me.btnGenerateCSR.Location = New System.Drawing.Point(11, 124)
        Me.btnGenerateCSR.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerateCSR.Name = "btnGenerateCSR"
        Me.btnGenerateCSR.Size = New System.Drawing.Size(112, 24)
        Me.btnGenerateCSR.TabIndex = 2
        Me.btnGenerateCSR.Text = "Generate CSR"
        Me.btnGenerateCSR.UseVisualStyleBackColor = True
        '
        'btnGeneratePublicKey
        '
        Me.btnGeneratePublicKey.Location = New System.Drawing.Point(135, 30)
        Me.btnGeneratePublicKey.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGeneratePublicKey.Name = "btnGeneratePublicKey"
        Me.btnGeneratePublicKey.Size = New System.Drawing.Size(112, 24)
        Me.btnGeneratePublicKey.TabIndex = 1
        Me.btnGeneratePublicKey.Text = "Generate Public Key"
        Me.btnGeneratePublicKey.UseVisualStyleBackColor = True
        '
        'btnGeneratePrivateKey
        '
        Me.btnGeneratePrivateKey.Location = New System.Drawing.Point(11, 30)
        Me.btnGeneratePrivateKey.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGeneratePrivateKey.Name = "btnGeneratePrivateKey"
        Me.btnGeneratePrivateKey.Size = New System.Drawing.Size(112, 24)
        Me.btnGeneratePrivateKey.TabIndex = 0
        Me.btnGeneratePrivateKey.Text = "Generate Private Key"
        Me.btnGeneratePrivateKey.UseVisualStyleBackColor = True
        '
        'grpEncryption
        '
        Me.grpEncryption.Controls.Add(Me.txtHashResult)
        Me.grpEncryption.Controls.Add(Me.lblHashResult)
        Me.grpEncryption.Controls.Add(Me.btnEncryptSHA256)
        Me.grpEncryption.Controls.Add(Me.txtDataToEncrypt)
        Me.grpEncryption.Controls.Add(Me.lblDataToEncrypt)
        Me.grpEncryption.Location = New System.Drawing.Point(9, 250)
        Me.grpEncryption.Margin = New System.Windows.Forms.Padding(2)
        Me.grpEncryption.Name = "grpEncryption"
        Me.grpEncryption.Padding = New System.Windows.Forms.Padding(2)
        Me.grpEncryption.Size = New System.Drawing.Size(300, 162)
        Me.grpEncryption.TabIndex = 2
        Me.grpEncryption.TabStop = False
        Me.grpEncryption.Text = "SHA256 Hash"
        '
        'txtHashResult
        '
        Me.txtHashResult.Location = New System.Drawing.Point(11, 128)
        Me.txtHashResult.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHashResult.Name = "txtHashResult"
        Me.txtHashResult.ReadOnly = True
        Me.txtHashResult.Size = New System.Drawing.Size(275, 20)
        Me.txtHashResult.TabIndex = 4
        '
        'lblHashResult
        '
        Me.lblHashResult.AutoSize = True
        Me.lblHashResult.Location = New System.Drawing.Point(11, 107)
        Me.lblHashResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHashResult.Name = "lblHashResult"
        Me.lblHashResult.Size = New System.Drawing.Size(68, 13)
        Me.lblHashResult.TabIndex = 3
        Me.lblHashResult.Text = "Hash Result:"
        '
        'btnEncryptSHA256
        '
        Me.btnEncryptSHA256.Location = New System.Drawing.Point(11, 71)
        Me.btnEncryptSHA256.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEncryptSHA256.Name = "btnEncryptSHA256"
        Me.btnEncryptSHA256.Size = New System.Drawing.Size(112, 24)
        Me.btnEncryptSHA256.TabIndex = 2
        Me.btnEncryptSHA256.Text = "Generate SHA256"
        Me.btnEncryptSHA256.UseVisualStyleBackColor = True
        '
        'txtDataToEncrypt
        '
        Me.txtDataToEncrypt.Location = New System.Drawing.Point(11, 42)
        Me.txtDataToEncrypt.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDataToEncrypt.Name = "txtDataToEncrypt"
        Me.txtDataToEncrypt.Size = New System.Drawing.Size(275, 20)
        Me.txtDataToEncrypt.TabIndex = 1
        '
        'lblDataToEncrypt
        '
        Me.lblDataToEncrypt.AutoSize = True
        Me.lblDataToEncrypt.Location = New System.Drawing.Point(11, 22)
        Me.lblDataToEncrypt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDataToEncrypt.Name = "lblDataToEncrypt"
        Me.lblDataToEncrypt.Size = New System.Drawing.Size(73, 13)
        Me.lblDataToEncrypt.TabIndex = 0
        Me.lblDataToEncrypt.Text = "Data to Hash:"
        '
        'grpSignature
        '
        Me.grpSignature.Controls.Add(Me.btnVerifySignatureCrypto)
        Me.grpSignature.Controls.Add(Me.txtSignatureToVerify)
        Me.grpSignature.Controls.Add(Me.lblSignatureToVerify)
        Me.grpSignature.Controls.Add(Me.txtDataToVerify)
        Me.grpSignature.Controls.Add(Me.lblDataToVerify)
        Me.grpSignature.Controls.Add(Me.btnVerifySignature)
        Me.grpSignature.Controls.Add(Me.txtSignature)
        Me.grpSignature.Controls.Add(Me.lblSignature)
        Me.grpSignature.Controls.Add(Me.btnSignData)
        Me.grpSignature.Controls.Add(Me.txtDataToSign)
        Me.grpSignature.Controls.Add(Me.lblDataToSign)
        Me.grpSignature.Location = New System.Drawing.Point(322, 250)
        Me.grpSignature.Margin = New System.Windows.Forms.Padding(2)
        Me.grpSignature.Name = "grpSignature"
        Me.grpSignature.Padding = New System.Windows.Forms.Padding(2)
        Me.grpSignature.Size = New System.Drawing.Size(262, 268)
        Me.grpSignature.TabIndex = 3
        Me.grpSignature.TabStop = False
        Me.grpSignature.Text = "Digital Signature"
        '
        'btnVerifySignatureCrypto
        '
        Me.btnVerifySignatureCrypto.Location = New System.Drawing.Point(135, 238)
        Me.btnVerifySignatureCrypto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVerifySignatureCrypto.Name = "btnVerifySignatureCrypto"
        Me.btnVerifySignatureCrypto.Size = New System.Drawing.Size(112, 24)
        Me.btnVerifySignatureCrypto.TabIndex = 10
        Me.btnVerifySignatureCrypto.Text = "Verify Signature 2"
        Me.btnVerifySignatureCrypto.UseVisualStyleBackColor = True
        '
        'txtSignatureToVerify
        '
        Me.txtSignatureToVerify.Location = New System.Drawing.Point(11, 201)
        Me.txtSignatureToVerify.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSignatureToVerify.Multiline = True
        Me.txtSignatureToVerify.Name = "txtSignatureToVerify"
        Me.txtSignatureToVerify.Size = New System.Drawing.Size(237, 33)
        Me.txtSignatureToVerify.TabIndex = 9
        '
        'lblSignatureToVerify
        '
        Me.lblSignatureToVerify.AutoSize = True
        Me.lblSignatureToVerify.Location = New System.Drawing.Point(11, 180)
        Me.lblSignatureToVerify.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSignatureToVerify.Name = "lblSignatureToVerify"
        Me.lblSignatureToVerify.Size = New System.Drawing.Size(96, 13)
        Me.lblSignatureToVerify.TabIndex = 8
        Me.lblSignatureToVerify.Text = "Signature to Verify:"
        '
        'txtDataToVerify
        '
        Me.txtDataToVerify.Location = New System.Drawing.Point(11, 152)
        Me.txtDataToVerify.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDataToVerify.Name = "txtDataToVerify"
        Me.txtDataToVerify.Size = New System.Drawing.Size(237, 20)
        Me.txtDataToVerify.TabIndex = 7
        '
        'lblDataToVerify
        '
        Me.lblDataToVerify.AutoSize = True
        Me.lblDataToVerify.Location = New System.Drawing.Point(11, 132)
        Me.lblDataToVerify.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDataToVerify.Name = "lblDataToVerify"
        Me.lblDataToVerify.Size = New System.Drawing.Size(74, 13)
        Me.lblDataToVerify.TabIndex = 6
        Me.lblDataToVerify.Text = "Data to Verify:"
        '
        'btnVerifySignature
        '
        Me.btnVerifySignature.Location = New System.Drawing.Point(11, 237)
        Me.btnVerifySignature.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVerifySignature.Name = "btnVerifySignature"
        Me.btnVerifySignature.Size = New System.Drawing.Size(112, 24)
        Me.btnVerifySignature.TabIndex = 5
        Me.btnVerifySignature.Text = "Verify Signature"
        Me.btnVerifySignature.UseVisualStyleBackColor = True
        '
        'txtSignature
        '
        Me.txtSignature.Location = New System.Drawing.Point(11, 91)
        Me.txtSignature.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSignature.Multiline = True
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.ReadOnly = True
        Me.txtSignature.Size = New System.Drawing.Size(237, 33)
        Me.txtSignature.TabIndex = 4
        '
        'lblSignature
        '
        Me.lblSignature.AutoSize = True
        Me.lblSignature.Location = New System.Drawing.Point(11, 71)
        Me.lblSignature.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(55, 13)
        Me.lblSignature.TabIndex = 3
        Me.lblSignature.Text = "Signature:"
        '
        'btnSignData
        '
        Me.btnSignData.Location = New System.Drawing.Point(135, 37)
        Me.btnSignData.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSignData.Name = "btnSignData"
        Me.btnSignData.Size = New System.Drawing.Size(112, 24)
        Me.btnSignData.TabIndex = 2
        Me.btnSignData.Text = "Sign Data"
        Me.btnSignData.UseVisualStyleBackColor = True
        '
        'txtDataToSign
        '
        Me.txtDataToSign.Location = New System.Drawing.Point(11, 42)
        Me.txtDataToSign.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDataToSign.Name = "txtDataToSign"
        Me.txtDataToSign.Size = New System.Drawing.Size(114, 20)
        Me.txtDataToSign.TabIndex = 1
        '
        'lblDataToSign
        '
        Me.lblDataToSign.AutoSize = True
        Me.lblDataToSign.Location = New System.Drawing.Point(11, 22)
        Me.lblDataToSign.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDataToSign.Name = "lblDataToSign"
        Me.lblDataToSign.Size = New System.Drawing.Size(69, 13)
        Me.lblDataToSign.TabIndex = 0
        Me.lblDataToSign.Text = "Data to Sign:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 535)
        Me.Controls.Add(Me.grpSignature)
        Me.Controls.Add(Me.grpEncryption)
        Me.Controls.Add(Me.grpFileGeneration)
        Me.Controls.Add(Me.grpCertificateInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SSL Certificate Manager"
        Me.grpCertificateInfo.ResumeLayout(False)
        Me.grpCertificateInfo.PerformLayout()
        Me.grpFileGeneration.ResumeLayout(False)
        Me.grpFileGeneration.PerformLayout()
        Me.grpEncryption.ResumeLayout(False)
        Me.grpEncryption.PerformLayout()
        Me.grpSignature.ResumeLayout(False)
        Me.grpSignature.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCertificateInfo As GroupBox
    Friend WithEvents txtCommonName As TextBox
    Friend WithEvents lblCommonName As Label
    Friend WithEvents txtOrganization As TextBox
    Friend WithEvents lblOrganization As Label
    Friend WithEvents txtOrganizationalUnit As TextBox
    Friend WithEvents lblOrganizationalUnit As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents lblState As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents lblCountry As Label
    Friend WithEvents txtValidityYears As TextBox
    Friend WithEvents lblValidityYears As Label
    Friend WithEvents grpFileGeneration As GroupBox
    Friend WithEvents btnGeneratePrivateKey As Button
    Friend WithEvents btnGeneratePublicKey As Button
    Friend WithEvents btnGenerateCSR As Button
    Friend WithEvents btnGeneratePEM As Button
    Friend WithEvents btnGenerateP12 As Button
    Friend WithEvents btnGenerateCER As Button
    Friend WithEvents txtP12Password As TextBox
    Friend WithEvents lblP12Password As Label
    Friend WithEvents grpEncryption As GroupBox
    Friend WithEvents txtDataToEncrypt As TextBox
    Friend WithEvents lblDataToEncrypt As Label
    Friend WithEvents btnEncryptSHA256 As Button
    Friend WithEvents txtHashResult As TextBox
    Friend WithEvents lblHashResult As Label
    Friend WithEvents grpSignature As GroupBox
    Friend WithEvents txtDataToSign As TextBox
    Friend WithEvents lblDataToSign As Label
    Friend WithEvents btnSignData As Button
    Friend WithEvents txtSignature As TextBox
    Friend WithEvents lblSignature As Label
    Friend WithEvents btnVerifySignature As Button
    Friend WithEvents txtDataToVerify As TextBox
    Friend WithEvents lblDataToVerify As Label
    Friend WithEvents txtSignatureToVerify As TextBox
    Friend WithEvents lblSignatureToVerify As Label
    Friend WithEvents btnVerifySignatureCrypto As Button
End Class
