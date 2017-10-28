Public Class loginscreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        clocklabel.Text = DateTime.Now.ToString("HH:MM")
    End Sub
End Class