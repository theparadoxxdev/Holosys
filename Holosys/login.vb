Public Class login

    'Define variables
    Public version As String
    Public edition, serverstatus, debugc As Integer
    Public licensevalid, istestlicense As Boolean
    Dim username, password As String

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initialize variables
        debugc = 0
        version = "0.1.0"
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

    Private Sub serverstat_Tick(sender As Object, e As EventArgs) Handles serverstat.Tick

        'Check server connection status
        Select Case serverstatus
            Case 0
                lblServerStat.ForeColor = Color.Red
                lblServerStat.Text = "Server not responding"
                btnLogin.Enabled = False
            Case 1
                lblServerStat.ForeColor = Color.Red
                lblServerStat.Text = "Incompatible server version"
                btnLogin.Enabled = False
            Case 2
                lblServerStat.ForeColor = Color.Lime
                lblServerStat.Text = "Trusted Directory"
                btnLogin.Enabled = True
            Case 3
                lblServerStat.ForeColor = Color.Yellow
                lblServerStat.Text = "Certificate invalid"
                btnLogin.Enabled = False
        End Select

    End Sub

    Private Sub logo_Click(sender As Object, e As EventArgs) Handles logo.Click
        debugc += 1

        'Has the logo been clicked 10 times since init? If so, open debug window.
        '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        '                                           DISABLE THIS BEFORE FINAL RELEASE, HOLLY!!!
        '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        If debugc = 10 Then
            debug.Enabled = True
            debug.Show()
            debugc = 0
        End If

    End Sub

    Private Sub chkUseWinCred_CheckedChanged(sender As Object, e As EventArgs) Handles chkUseWinCred.CheckedChanged

        Select Case chkUseWinCred.Checked
            Case True
                txtUsername.Enabled = False
                txtPassword.Enabled = False
                username = System.Environment.UserDomainName + "\" + System.Environment.UserName()
                txtUsername.Text = username
            Case False
                txtUsername.Enabled = True
                txtPassword.Enabled = True
                username = Nothing
                password = Nothing
                txtUsername.Text = username
                txtPassword.Text = password
        End Select

    End Sub
End Class
