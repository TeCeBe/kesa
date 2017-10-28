Public Class bootstrap
    Dim installer As Boolean = False
    Private Sub bootstrap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Odczyt stanu instalacji
        Try
            If My.Computer.FileSystem.ReadAllText("C:\KESA\bootstrap\state.conf") = "1" Then
                Timer1.Start()
            End If
        Catch ex As Exception
            installer = True
            Timer1.Interval = 5000
            Label1.Show()
            Label1.Text = "Inicjowanie instalatora, proszę czekać..."
            Cursor.Hide()
            Timer1.Start()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Animacja + uruchomienie panelu logowania
    End Sub

    Private Sub bootstrap_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.R Then
            'Uruchomienie recovery
        End If
    End Sub
End Class
