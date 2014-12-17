Public Class OpenStatusClient

    Private Sub OpenStatusClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'OpenStatus-client - The frontend to the OpenStatus API/Library, the client.'
        'GNU GPL v3.0 or above - <http://gnu.org/licenses/gpl.txt>'

        If My.Settings.IsFirstTime Then
            My.Settings.IsFirstTime = False
            My.Settings.Username = InputBox("Welcome to the OpenStatus-client! (v" & My.Application.Info.Version.ToString & ")" _
                                            & vbNewLine & "Please enter your (to-be) username:")
        End If
        
        Dim count = 0
        For Each args In My.Application.CommandLineArgs
            count = count + 1


        Next
    End Sub

    Private Sub btnChangeUsername_Click(sender As Object, e As EventArgs) Handles btnChangeUsername.Click
        My.Settings.Username = InputBox("[OpenStatus] Enter new username:", , My.Settings.Username)
    End Sub
End Class
