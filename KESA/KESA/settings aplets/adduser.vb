﻿Public Class adduser
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
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuFlatButton1.Text = "Zakończ"
        Label8.Hide()
        BunifuFlatButton1.Enabled = True
        BunifuSeparator3.Show()
        Label6.ForeColor = Color.White
        tab = 3
    End Sub
End Class