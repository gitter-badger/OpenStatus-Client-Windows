Imports System.IO.File

Public Class OpenStatusClient
    Dim connectingServer As String

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
        If My.Settings.AutoConnect Then
            btnServer.Text = "Disconnect"
            SetServer()
        Else
            btnServer_Click()
        End If
        chkAutoConnect.Checked = My.Settings.AutoConnect
    End Sub

    Private Sub btnChangeUsername_Click(sender As Object, e As EventArgs) Handles btnChangeUsername.Click
        My.Settings.Username = InputBox("Enter new username:", , My.Settings.Username)
        SetUsername()
    End Sub

    Sub SetUsername()
        lblUsername.Text = "Username: " & My.Settings.Username
    End Sub

    Private Sub btnServer_Click() Handles btnServer.Click
        If btnServer.Text = "Connect to a server..." Then
            connectingServer = InputBox("Enter server address to connect to:", , My.Settings.lastServer)
            If Exists(connectingServer & "\.config\OpenStatus") Then
                My.Settings.lastServer = connectingServer
                btnServer.Text = "Disconnect"
                SetServer()
            End If
        ElseIf btnServer.Text = "Disconnect" Then
            btnServer.Text = "Connect to a server..."
            lblServer.Text = "Server: NOT_CONNECTED"
        End If
    End Sub

    Sub SetServer()
        For Each line In ReadLines(My.Settings.lastServer & "\.config\OpenStatus")

        Next
        lblServer.Text = "Server: " & My.Settings.lastServer
    End Sub

    Private Sub chkAutoConnect_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoConnect.CheckedChanged
        My.Settings.AutoConnect = chkAutoConnect.Checked
    End Sub
End Class
