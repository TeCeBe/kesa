Public Class bg_black
    Private Sub bg_black_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        integrityverifier.BringToFront()
        integrityverifier.Activate()
    End Sub

    Private Sub bg_black_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        integrityverifier.BringToFront()
        integrityverifier.Activate()
    End Sub

    Private Sub bg_black_Load(sender As Object, e As EventArgs) Handles Me.Load
        integrityverifier.Show()
    End Sub
End Class