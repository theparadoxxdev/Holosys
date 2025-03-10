<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class debug
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cbxServerConnection = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' cbxServerConnection
        ' 
        cbxServerConnection.FormattingEnabled = True
        cbxServerConnection.Items.AddRange(New Object() {"Server not responding", "Incompatible Server Version", "Trusted Directory", "Invalid Certificate"})
        cbxServerConnection.Location = New Point(22, 102)
        cbxServerConnection.Name = "cbxServerConnection"
        cbxServerConnection.Size = New Size(212, 23)
        cbxServerConnection.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(293, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 21)
        Label1.TabIndex = 1
        Label1.Text = "Holosys Client Debug Interface"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(38, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(187, 15)
        Label2.TabIndex = 2
        Label2.Text = "Server Connection Status Override"
        ' 
        ' debug
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cbxServerConnection)
        Enabled = False
        Name = "debug"
        ShowIcon = False
        SizeGripStyle = SizeGripStyle.Hide
        Text = "Debug Window"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbxServerConnection As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
