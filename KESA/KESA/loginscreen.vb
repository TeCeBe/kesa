Imports System.IO

Public Class loginscreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        clocklabel.Text = DateTime.Now.ToString("HH:MM")
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        login_in()
        BunifuThinButton21.Hide()
    End Sub

    Private Sub loginscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each Dir As String In Directory.GetDirectories("C:\KESA\users")
                Dim dirInfo As New System.IO.DirectoryInfo(Dir)
                ComboBox1.Items.Add(dirInfo.Name)
            Next
            Dim dir_count As Integer = System.IO.Directory.GetDirectories("C:\KESA\users").Length
            If dir_count < 2 Then
                ComboBox1.SelectedIndex = 0
                ComboBox1.Enabled = False
                Dim psw As String = My.Computer.FileSystem.ReadAllText("C:\KESA\users\" + ComboBox1.SelectedItem + "\password.conf")
                If psw = "" Then
                    TextBox1.Hide()
                Else
                    BunifuThinButton21.Hide()
                End If
            Else
                BunifuThinButton21.Hide()
                TextBox1.Hide()
                PictureBox6.Hide()
            End If
        Catch ex As Exception
            Label2.Text = "Aplikacja Usługa logowania przestała działać. Jeżeli problem będzie się powtarzał, napraw system za pomocą narzędzia Recovery."
            Label2.Show()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim psw As String = My.Computer.FileSystem.ReadAllText("C:\KESA\users\" + ComboBox1.SelectedItem + "\password.conf")
        If psw = "" Then
            TextBox1.Hide()
            PictureBox6.Hide()
            BunifuThinButton21.Show()
        Else
            BunifuThinButton21.Hide()
            TextBox1.Show()
            PictureBox6.Show()
        End If
        Label2.Hide()
        TextBox1.Text = ""
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim psw As String = My.Computer.FileSystem.ReadAllText("C:\KESA\users\" + ComboBox1.SelectedItem + "\password.conf")
        If psw = TextBox1.Text Then
            login_in()
            TextBox1.Hide()
            PictureBox6.Hide()
        Else
            Label2.Text = "Podane hasło jest nieprawidłowe."
            Label2.Show()
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub login_in()
        Label2.Hide()
        MsgBox("ok")
    End Sub
End Class