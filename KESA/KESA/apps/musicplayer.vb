Public Class musicplayer
    Dim playerstate_shuffle As Integer = 0
    Dim playerstate_repeat As Integer = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BunifuSlider2_ValueChanged(sender As Object, e As EventArgs) Handles BunifuSlider2.ValueChanged
        If BunifuSlider2.Value = 0 Then
            PictureBox5.BackgroundImage = My.Resources.player_speakermute
        Else
            PictureBox5.BackgroundImage = My.Resources.player_speaker100
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles shuffleoff.Click
        shuffleon.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles repeatoff.Click
        repeaton.Show()
    End Sub

    Private Sub shuffleon_Click(sender As Object, e As EventArgs) Handles shuffleon.Click
        shuffleon.Hide()
    End Sub

    Private Sub repeaton_Click(sender As Object, e As EventArgs) Handles repeaton.Click
        repeaton.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim dlg As New OpenFileDialog
        dlg.Filter = "*.mp3|*.mp3"
        dlg.ShowDialog

        Label1.Text = dlg.FileName.ToString

    End Sub
End Class