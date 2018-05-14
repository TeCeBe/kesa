Public Class errorscreen
    Private Sub errorscreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BringToFront()
        Me.Activate()
    End Sub

    Private Sub errorscreen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.BringToFront()
        Me.Activate()
    End Sub
End Class