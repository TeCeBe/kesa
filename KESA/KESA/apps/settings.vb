Public Class settings
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TabPage15_Click(sender As Object, e As EventArgs) Handles TabPage15.Click

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        TabControl1.SelectedTab = TabPage1
        BunifuThinButton21.Hide()
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        TabControl1.SelectedTab = tab_system
        BunifuThinButton21.Show()
    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        TabControl1.SelectedTab = tab_network
        BunifuThinButton21.Show()
    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        TabControl1.SelectedTab = tab_personalization
        BunifuThinButton21.Show()
    End Sub

    Private Sub BunifuTileButton4_Click(sender As Object, e As EventArgs) Handles BunifuTileButton4.Click
        TabControl1.SelectedTab = tab_accounts
        BunifuThinButton21.Show()
    End Sub

    Private Sub BunifuTileButton5_Click(sender As Object, e As EventArgs) Handles BunifuTileButton5.Click
        TabControl1.SelectedTab = tab_updates
        BunifuThinButton21.Show()
    End Sub

    Private Sub BunifuTileButton6_Click(sender As Object, e As EventArgs) Handles BunifuTileButton6.Click
        TabControl1.SelectedTab = tab_advanced
        BunifuThinButton21.Show()
    End Sub

    Private Sub BunifuTileButton7_Click(sender As Object, e As EventArgs) Handles BunifuTileButton7.Click
        TabControl1.SelectedTab = tab_cloud
        BunifuThinButton21.Show()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub BunifuCheckbox1_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox1.OnChange

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class