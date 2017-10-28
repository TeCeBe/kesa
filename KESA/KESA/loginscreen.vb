Public Class loginscreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        clocklabel.Text = DateTime.Now.ToString("HH:MM")
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

    End Sub

    Private Sub loginscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dir_count As Integer = System.IO.Directory.GetDirectories("C:\KESA\users").Length
            If dir_count < 2 Then
                ComboBox1.Enabled = False
            End If
        Catch ex As Exception
            Label2.Text = "Aplikacja Usługa logowania przestała działać. Jeżeli problem będzie się powtarzał, napraw system za pomocą narzędzia Recovery."
            Label2.Show()
        End Try
    End Sub
End Class