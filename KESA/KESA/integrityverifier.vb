Public Class integrityverifier
    Private Sub integrityverifier_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.BringToFront()
        Me.Activate()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuProgressBar1.Value = BunifuProgressBar1.Value + 1
        Label3.Text = BunifuProgressBar1.Value & "%"
        If BunifuProgressBar1.Value = 100 Then
            Timer1.Stop()
        End If
    End Sub
End Class