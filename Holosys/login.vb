Public Class login

    'Define variables
    Dim version As String
    Dim edition As Integer
    Dim licensevalid As Boolean
    Dim istestlicense As Boolean

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initialize variables
        Version = Me.ProductVersion
        edition = 2
        licensevalid = False
        istestlicense = False

        'Display installed version
        lblVersion.Text = Version

        'Display installed edition
        Select Case edition
            Case 1
                lblEdition.Text = "Free Edition"
            Case 2
                lblEdition.Text = "Surveillance Edition"
            Case 3
                lblEdition.Text = "ACS Edition"
            Case 4
                lblEdition.Text = "Enterprise Edition"
        End Select

        'If the user is running Free Edition, then skip license check
        If edition = 1 Then
            lblLicense.Text = "License is not required"
            Exit Sub
        End If

        'Check if license exists; Closes with error if not found
        If My.Computer.FileSystem.FileExists("C:\Holosys\license.lic") = False Then
            MessageBox.Show("The license file cannot be found on this system. Holosys will now close. Please reinstall Holosys.", "License does not exist")
            Close()
        Else
            Dim licensefile = My.Computer.FileSystem.ReadAllBytes("C:\Holosys\license.lic")
            If licensefile Is "aaabbbcccddd1011289" Then
                istestlicense = True
            End If
        End If

        'License validity check
        Select Case licensevalid
            Case True And istestlicense = False
                lblLicense.Text = "License is valid"
            Case True And istestlicense = True
                lblLicense.Text = "Test license installed"
                lblEdition.Text = "Enterprise Edition"
            Case False
                lblLicense.Text = "License is not valid"
                flashmessage.Enabled = True
        End Select
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub flashmessage_Tick(sender As Object, e As EventArgs) Handles flashmessage.Tick

        'Flash the invalid license message
        If lblLicense.Visible = True Then
            lblLicense.Visible = False
        Else
            lblLicense.Visible = True
        End If

    End Sub

End Class
