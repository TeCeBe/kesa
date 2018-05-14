Public Class bg
    Private Sub bg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "build"
        Dim str_build As String
        str_build = My.Computer.FileSystem.ReadAllText("C:\Kesa\$settings\version\build.ini")
        Label1.Text = str_build
        Label1.ForeColor = Color.FromArgb(255, Color.White)
#End Region
#Region "version"
        Dim str_version As String
        str_version = My.Computer.FileSystem.ReadAllText("C:\Kesa\$settings\version\version.ini")
        Label2.Text = str_version
        Label2.ForeColor = Color.FromArgb(255, Color.White)
#End Region
#Region "status"
        Dim str_status As String
        str_status = My.Computer.FileSystem.ReadAllText("C:\Kesa\$settings\version\status.ini")
        Label3.Text = str_status
        Label3.ForeColor = Color.FromArgb(255, Color.White)
#End Region
        errorscreen.Show()
        errorscreen.BringToFront()
        If My.Settings.adv_dumpLogs = "True" Then

        End If
    End Sub

    Private Sub bg_Click(sender As Object, e As EventArgs) Handles Me.Click
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub bg_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub bg_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub
#Region "labels"
    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub Label2_MouseUp(sender As Object, e As MouseEventArgs) Handles Label2.MouseUp
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs) Handles Label3.MouseDown
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub Label3_MouseUp(sender As Object, e As MouseEventArgs) Handles Label3.MouseUp
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub Label4_MouseUp(sender As Object, e As MouseEventArgs) Handles Label4.MouseUp
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub Label5_MouseUp(sender As Object, e As MouseEventArgs) Handles Label5.MouseUp
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub Label6_MouseDown(sender As Object, e As MouseEventArgs) Handles errorcode.MouseDown
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub Label6_MouseUp(sender As Object, e As MouseEventArgs) Handles errorcode.MouseUp
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles desc.MouseDown
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub Label7_MouseUp(sender As Object, e As MouseEventArgs) Handles desc.MouseUp
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub Label8_MouseDown(sender As Object, e As MouseEventArgs) Handles process.MouseDown
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub Label8_MouseUp(sender As Object, e As MouseEventArgs) Handles process.MouseUp
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub PictureBox5_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseDown
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

    Private Sub PictureBox5_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseUp
        errorscreen.BringToFront()
        errorscreen.Activate()
    End Sub

#End Region
End Class