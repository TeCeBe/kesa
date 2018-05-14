Public Class settings
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        anim_fadein.Start()
    End Sub

    Private Sub TabPage15_Click(sender As Object, e As EventArgs) Handles TabPage15.Click

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        TabControl1.SelectedTab = TabPage1
        BunifuThinButton21.Hide()
        Label1.Text = "Ustawienia"
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        TabControl1.SelectedTab = tab_system
        BunifuThinButton21.Show()
        Label1.Text = "System"
    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        TabControl1.SelectedTab = tab_network
        BunifuThinButton21.Show()
        Label1.Text = "Sieć"
    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        TabControl1.SelectedTab = tab_personalization
        BunifuThinButton21.Show()
        Label1.Text = "Personalizacja"
    End Sub

    Private Sub BunifuTileButton4_Click(sender As Object, e As EventArgs) Handles BunifuTileButton4.Click
        TabControl1.SelectedTab = tab_accounts
        BunifuThinButton21.Show()
        Label1.Text = "Konta"
    End Sub

    Private Sub BunifuTileButton5_Click(sender As Object, e As EventArgs) Handles BunifuTileButton5.Click
        TabControl1.SelectedTab = tab_updates
        BunifuThinButton21.Show()
        Label1.Text = "Aktualizacje"
    End Sub

    Private Sub BunifuTileButton6_Click(sender As Object, e As EventArgs) Handles BunifuTileButton6.Click
        TabControl1.SelectedTab = tab_advanced
        BunifuThinButton21.Show()
        Label1.Text = "Ustaw. zaaw."
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub BunifuCheckbox1_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox1.OnChange

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        TabControl5.SelectedTab = TabPage16
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        TabControl5.SelectedTab = TabPage15
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs)
        adduser.Show()
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        adduser.Show()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub anim_fadein_Tick(sender As Object, e As EventArgs) Handles anim_fadein.Tick
        Me.Opacity = Me.Opacity + 0.15
        If Me.Opacity = 1 Then
            anim_fadein.Stop()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        anim_fadeout.Start()
    End Sub

    Private Sub anim_fadeout_Tick(sender As Object, e As EventArgs) Handles anim_fadeout.Tick
        Me.Opacity = Me.Opacity - 0.15
        If Me.Opacity = 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        about.Show()
    End Sub

    Private Sub BunifuCheckbox2_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox2.OnChange
        If BunifuCheckbox2.Checked = True Then
            My.Settings.adv_dumpLogs = "True"
            My.Settings.Save()
        End If
    End Sub
End Class