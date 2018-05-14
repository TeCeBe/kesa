Imports System.IO

Public Class loginscreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("HH:MM")
    End Sub
End Class