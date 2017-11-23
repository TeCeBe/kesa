Public Class adduser
    Dim tab As Int16 = 1
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If tab = 3 Then
            Me.Close()
        End If
        If tab = 2 Then
            If Not BunifuMetroTextbox2.Text = BunifuMetroTextbox3.Text Then
                msgbox_warning.title.Text = "Sprawdź zawartość formularza"
                msgbox_warning.info.Text = "Hasła nie pasują do siebie."
                msgbox_warning.Show()
            Else
                Label8.Show()
                Panel1.Hide()
                Timer1.Start()
                Label5.ForeColor = Color.Gray
                BunifuSeparator2.Hide()
                BunifuFlatButton1.Enabled = False
                PictureBox1.Hide()
                Label6.ForeColor = Color.Gray
            End If
        End If
        If tab = 1 Then
            If IO.Directory.Exists("C:\KESA\users\" + BunifuMetroTextbox1.Text) Then
                msgbox_error.title.Text = "Wystąpił błąd krytyczny"
                msgbox_error.info.Text = "Wybrana nazwa jest już zajęta." + vbNewLine + "Wpisz inną i spróbuj ponownie."
                msgbox_error.Show()
            Else
                If BunifuMetroTextbox1.Text = "" Then
                    msgbox_warning.title.Text = "Uzupełnij wszystkie pola!"
                    msgbox_warning.info.Text = "Pole z nazwą użytkownika jest puste."
                    msgbox_warning.Show()
                Else
                    tab = 2
                    BunifuSeparator1.Hide()
                    BunifuSeparator2.Show()
                    Label4.ForeColor = Color.Gray
                    TabControl1.SelectedTab = TabPage2
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            'Tworzenie podstawowych katalogów
            MkDir("C:\KESA\users\" + BunifuMetroTextbox1.Text)
            MkDir("C:\KESA\users\" + BunifuMetroTextbox1.Text + "\userdata\")
            MkDir("C:\KESA\users\" + BunifuMetroTextbox1.Text + "\usersettings\")
            'Tworzenie pliku hasła
            My.Computer.FileSystem.WriteAllText("C:\KESA\users\" + BunifuMetroTextbox1.Text + "\password.conf", BunifuMetroTextbox2.Text, False)
            'Finalizacja formularza
            BunifuFlatButton1.Text = "Zakończ"
            Label8.Hide()
            BunifuFlatButton1.Enabled = True
            BunifuSeparator3.Show()
            Label6.ForeColor = Color.White
            tab = 3
        Catch ex As Exception
            msgbox_error.title.Text = "Wystąpił błąd krytyczny"
            msgbox_error.info.Text = "Nie można utworzyć nowego konta: " + vbNewLine + ex.Message
            msgbox_error.Show()
            Me.Close()
        End Try
    End Sub
End Class