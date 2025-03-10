Public Class debug
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxServerConnection.SelectedIndexChanged
        Select Case cbxServerConnection.SelectedItem
            Case "Server not responding"
                login.serverstatus = 0
            Case "Incompatible Server Version"
                login.serverstatus = 1
            Case "Trusted Directory"
                login.serverstatus = 2
            Case "Invalid Certificate"
                login.serverstatus = 3
        End Select
    End Sub
End Class