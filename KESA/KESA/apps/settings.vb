Public Class settings
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TabPage15_Click(sender As Object, e As EventArgs) Handles TabPage15.Click

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        TabControl1.SelectedTab = TabPage1
        BunifuThinButton21.Hide()
    End Sub
End Class