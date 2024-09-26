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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnClose = New Button()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' logo
        ' 
        logo.Image = My.Resources.Resources.hslogodark
        logo.Location = New Point(29, 628)
        logo.Name = "logo"
        logo.Size = New Size(571, 138)
        logo.SizeMode = PictureBoxSizeMode.CenterImage
        logo.TabIndex = 0
        logo.TabStop = False
        ' 
        ' lblVersion
        ' 
        lblVersion.AutoSize = True
        lblVersion.Font = New Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblVersion.ForeColor = Color.White
        lblVersion.Location = New Point(29, 446)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(0, 49)
        lblVersion.TabIndex = 1
        ' 
        ' lblLicense
        ' 
        lblLicense.AutoSize = True
        lblLicense.Font = New Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblLicense.ForeColor = Color.White
        lblLicense.Location = New Point(29, 544)
        lblLicense.Name = "lblLicense"
        lblLicense.Size = New Size(0, 49)
        lblLicense.TabIndex = 2
        ' 
        ' lblEdition
        ' 
        lblEdition.AutoSize = True
        lblEdition.Font = New Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblEdition.ForeColor = Color.White
        lblEdition.Location = New Point(29, 495)
        lblEdition.Name = "lblEdition"
        lblEdition.Size = New Size(0, 49)
        lblEdition.TabIndex = 3
        ' 
        ' flashmessage
        ' 
        flashmessage.Interval = 500
        ' 
        ' btnLogin
        ' 
        btnLogin.Enabled = False
        btnLogin.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.Location = New Point(1032, 733)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 33)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtServer
        ' 
        txtServer.Location = New Point(712, 79)
        txtServer.Name = "txtServer"
        txtServer.Size = New Size(414, 27)
        txtServer.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(712, 588)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(414, 27)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(712, 667)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(414, 27)
        TextBox2.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(851, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 26)
        Label1.TabIndex = 8
        Label1.Text = "Server Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(880, 551)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 26)
        Label2.TabIndex = 9
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(880, 629)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 26)
        Label3.TabIndex = 10
        Label3.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label4.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Lime
        Label4.Location = New Point(712, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(414, 26)
        Label4.TabIndex = 11
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Firebrick
        btnClose.ForeColor = SystemColors.ButtonFace
        btnClose.Location = New Point(12, 12)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(34, 29)
        btnClose.TabIndex = 12
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1193, 806)
        Controls.Add(btnClose)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(txtServer)
        Controls.Add(btnLogin)
        Controls.Add(lblEdition)
        Controls.Add(lblLicense)
        Controls.Add(lblVersion)
        Controls.Add(logo)
        FormBorderStyle = FormBorderStyle.None
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClose As Button

End Class
