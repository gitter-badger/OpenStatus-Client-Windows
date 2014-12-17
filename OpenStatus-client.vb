Imports System.IO.File

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
        If My.Settings.AutoConnect Then
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
            serverSelectorDialog.SelectedPath = My.Settings.lastServer
            serverSelectorDialog.ShowDialog()
            If Exists(serverSelectorDialog.SelectedPath & "\.config\OpenStatus") Then
                My.Settings.lastServer = serverSelectorDialog.SelectedPath
                SetServer()
            Else
                MsgBox("Server info not found! Please select a valid server folder, Or generate a new one with the backend")
            End If
        ElseIf btnServer.Text = "Disconnect" Then
            btnServer.Text = "Connect to a server..."
            lblServer.Text = "Server: NOT_CONNECTED"
        End If
    End Sub

    Sub SetServer()
        For Each line In ReadLines(My.Settings.lastServer & "\.config\OpenStatus")

        Next
        btnServer.Text = "Disconnect"
        lblServer.Text = "Server: " & My.Settings.lastServer
    End Sub

    Private Sub chkAutoConnect_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoConnect.CheckedChanged
        My.Settings.AutoConnect = chkAutoConnect.Checked
    End Sub
End Class
