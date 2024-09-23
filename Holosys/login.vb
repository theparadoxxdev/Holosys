Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Define variables
        Dim version As String
        Dim edition As Integer
        Dim license As Integer

        'Initialize variables
        version = Me.ProductVersion
        edition = 2
        license = False

        'Display installed version
        lblVersion.Text = version

        If edition = 1 Then
            lblEdition.Text = "Free Edition"
        ElseIf edition = 2 Then
            lblEdition.Text = "Surveilance Edition"
        ElseIf edition = 3 Then
            lblEdition.Text = "ACS Edition"
        ElseIf edition = 4 Then
            lblEdition.Text = "Enterprise Edition"
        End If

        'If the user is running Free Edition, then skip license check
        If edition = 1 Then
            lblLicense.Text = "License Is not required"
        End If

        Select Case license
            Case True
                lblLicense.Text = "License is valid"
            Case False
                lblLicense.Text = "License is either not installed or is not valid"
                flashmessage.Enabled = True
        End Select
    End Sub

    Private Sub flashmessage_Tick(sender As Object, e As EventArgs) Handles flashmessage.Tick
        If lblLicense.Visible = True Then
            lblLicense.Visible = False
        Else
            lblLicense.Visible = True
        End If

    End Sub

End Class
