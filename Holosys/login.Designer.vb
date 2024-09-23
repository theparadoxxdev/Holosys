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
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' logo
        ' 
        logo.Image = My.Resources.Resources.hslogodark
        logo.Location = New Point(60, 581)
        logo.Name = "logo"
        logo.Size = New Size(609, 171)
        logo.SizeMode = PictureBoxSizeMode.AutoSize
        logo.TabIndex = 0
        logo.TabStop = False
        ' 
        ' lblVersion
        ' 
        lblVersion.AutoSize = True
        lblVersion.Font = New Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblVersion.ForeColor = Color.White
        lblVersion.Location = New Point(60, 374)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(0, 49)
        lblVersion.TabIndex = 1
        ' 
        ' lblLicense
        ' 
        lblLicense.AutoSize = True
        lblLicense.Font = New Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblLicense.ForeColor = Color.White
        lblLicense.Location = New Point(60, 472)
        lblLicense.Name = "lblLicense"
        lblLicense.Size = New Size(0, 49)
        lblLicense.TabIndex = 2
        ' 
        ' lblEdition
        ' 
        lblEdition.AutoSize = True
        lblEdition.Font = New Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblEdition.ForeColor = Color.White
        lblEdition.Location = New Point(60, 423)
        lblEdition.Name = "lblEdition"
        lblEdition.Size = New Size(0, 49)
        lblEdition.TabIndex = 3
        ' 
        ' flashmessage
        ' 
        flashmessage.Interval = 500
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1193, 806)
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

End Class
