<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        components = New ComponentModel.Container()
        logo = New PictureBox()
        lblVersion = New Label()
        lblLicense = New Label()
        lblEdition = New Label()
        flashmessage = New Timer(components)
        btnLogin = New Button()
        txtServer = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblServerStat = New Label()
        btnClose = New Button()
        chkUseWinCred = New CheckBox()
        serverstat = New Timer(components)
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' logo
        ' 
        logo.Image = My.Resources.Resources.hslogodark
        logo.Location = New Point(25, 450)
        logo.Margin = New Padding(3, 2, 3, 2)
        logo.Name = "logo"
        logo.Size = New Size(574, 125)
        logo.SizeMode = PictureBoxSizeMode.CenterImage
        logo.TabIndex = 0
        logo.TabStop = False
        ' 
        ' lblVersion
        ' 
        lblVersion.AutoSize = True
        lblVersion.Font = New Font("Trebuchet MS", 24F)
        lblVersion.ForeColor = Color.White
        lblVersion.Location = New Point(25, 334)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(0, 40)
        lblVersion.TabIndex = 1
        ' 
        ' lblLicense
        ' 
        lblLicense.AutoSize = True
        lblLicense.Font = New Font("Trebuchet MS", 24F)
        lblLicense.ForeColor = Color.White
        lblLicense.Location = New Point(25, 408)
        lblLicense.Name = "lblLicense"
        lblLicense.Size = New Size(0, 40)
        lblLicense.TabIndex = 2
        ' 
        ' lblEdition
        ' 
        lblEdition.AutoSize = True
        lblEdition.Font = New Font("Trebuchet MS", 24F)
        lblEdition.ForeColor = Color.White
        lblEdition.Location = New Point(25, 371)
        lblEdition.Name = "lblEdition"
        lblEdition.Size = New Size(0, 40)
        lblEdition.TabIndex = 3
        ' 
        ' flashmessage
        ' 
        flashmessage.Interval = 500
        ' 
        ' btnLogin
        ' 
        btnLogin.Enabled = False
        btnLogin.Font = New Font("Trebuchet MS", 12F)
        btnLogin.Location = New Point(903, 540)
        btnLogin.Margin = New Padding(3, 2, 3, 2)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(82, 35)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtServer
        ' 
        txtServer.Location = New Point(622, 62)
        txtServer.Margin = New Padding(3, 2, 3, 2)
        txtServer.Name = "txtServer"
        txtServer.Size = New Size(363, 23)
        txtServer.TabIndex = 5
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(623, 441)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(363, 23)
        txtUsername.TabIndex = 6
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(623, 500)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(363, 23)
        txtPassword.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 12F)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(745, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 22)
        Label1.TabIndex = 8
        Label1.Text = "Server Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 12F)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(759, 408)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 22)
        Label2.TabIndex = 9
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 12F)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(759, 471)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 22)
        Label3.TabIndex = 10
        Label3.Text = "Password"
        ' 
        ' lblServerStat
        ' 
        lblServerStat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        lblServerStat.Font = New Font("Trebuchet MS", 12F)
        lblServerStat.ForeColor = Color.Lime
        lblServerStat.Location = New Point(623, 98)
        lblServerStat.Name = "lblServerStat"
        lblServerStat.Size = New Size(362, 20)
        lblServerStat.TabIndex = 11
        lblServerStat.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Firebrick
        btnClose.ForeColor = SystemColors.ButtonFace
        btnClose.Location = New Point(10, 9)
        btnClose.Margin = New Padding(3, 2, 3, 2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(30, 22)
        btnClose.TabIndex = 12
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' chkUseWinCred
        ' 
        chkUseWinCred.AutoSize = True
        chkUseWinCred.Font = New Font("Trebuchet MS", 12F)
        chkUseWinCred.ForeColor = SystemColors.Control
        chkUseWinCred.Location = New Point(623, 540)
        chkUseWinCred.Name = "chkUseWinCred"
        chkUseWinCred.Size = New Size(209, 26)
        chkUseWinCred.TabIndex = 13
        chkUseWinCred.Text = "Use Windows Credentials"
        chkUseWinCred.UseVisualStyleBackColor = True
        ' 
        ' serverstat
        ' 
        serverstat.Enabled = True
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1044, 604)
        Controls.Add(chkUseWinCred)
        Controls.Add(btnClose)
        Controls.Add(lblServerStat)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(txtServer)
        Controls.Add(btnLogin)
        Controls.Add(lblEdition)
        Controls.Add(lblLicense)
        Controls.Add(lblVersion)
        Controls.Add(logo)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Holosys Login"
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents logo As PictureBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblLicense As Label
    Friend WithEvents lblEdition As Label
    Friend WithEvents flashmessage As Timer
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblServerStat As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents chkUseWinCred As CheckBox
    Friend WithEvents serverstat As Timer

End Class
