Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class desktop
    Dim session As String = "C:\Kesa\$settings\session.ini"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        about.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        settings.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        explorer.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        adduser.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'taskbar.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        terminal.Show()
    End Sub

    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.ReadAllText(session)

        Dim session_wallpaper As String = "C:\Kesa\$settings\users\" & My.Computer.FileSystem.ReadAllText(session) & "\wallpaper\wallpaper.ini"
        My.Computer.FileSystem.ReadAllText(session_wallpaper)
        Dim session_wallpaperlayout As String = "C:\Kesa\$settings\users\" & My.Computer.FileSystem.ReadAllText(session) & "\wallpaper\layout.prop"
        My.Computer.FileSystem.ReadAllText(session_wallpaperlayout)

        Label1.Location = New Point((ClientSize.Width - Label1.Width) \ 2)

        Timer1.Start()

#Region "Layout tapety"
        Me.BackgroundImage = Image.FromFile(My.Computer.FileSystem.ReadAllText("C:\Kesa\$settings\users\" & My.Computer.FileSystem.ReadAllText(session) & "\wallpaper\wallpaper.ini"))
        'If session_wallpaperlayout = "Tile" Then
        'Me.BackgroundImageLayout = ImageLayout.Tile
        'End If
        'If session_wallpaperlayout = "Center" Then
        'Me.BackgroundImageLayout = ImageLayout.Center
        'End If
        'If session_wallpaperlayout = "Stretch" Then
        'Me.BackgroundImageLayout = ImageLayout.Stretch
        'End If
        'If session_wallpaperlayout = "Zoom" Then
        'Me.BackgroundImageLayout = ImageLayout.Zoom
        'End If
        'If session_wallpaperlayout = Not "Tile" Or "Center" Or "Stretch" Or "Zoom" Then
        'Me.BackgroundImageLayout = ImageLayout.None
        'End If
#End Region

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        musicplayer.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay.ToShortTimeString
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        thirdpartymodules.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        System.Threading.Thread.Sleep(1000)
        bg.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        bg_black.Show()
    End Sub
End Class