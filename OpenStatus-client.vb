Public Class OpenStatusClient

    Private Sub OpenStatusClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim count = 0
        For Each args In My.Application.CommandLineArgs
            count = count + 1

        Next

        If My.Settings.IsFirstTime Then
            My.Settings.IsFirstTime = False
            My.Settings.Username = InputBox("Welcome to the OpenStatus-client! (v" & My.Application.Info.Version.ToString & ")" _
                                            & vbNewLine & "Please enter your (to-be) username:")
        End If
        SetUsername()
        btnServer_Click()

    End Sub

    Private Sub btnChangeUsername_Click(sender As Object, e As EventArgs) Handles btnChangeUsername.Click
        My.Settings.Username = InputBox("Enter new username:", , My.Settings.Username)
        SetUsername()
    End Sub

    Sub SetUsername()
        lblUsername.Text = "Username: " & My.Settings.Username
    End Sub

    Private Sub btnServer_Click() Handles btnServer.Click
        My.Settings.lastServer = InputBox("Enter server address:", , My.Settings.lastServer)
        btnServer.Text = "Disconnect"
        SetServer()
    End Sub

    Sub SetServer()
        lblServer.Text = "Server: " & My.Settings.lastServer
    End Sub
End Class
