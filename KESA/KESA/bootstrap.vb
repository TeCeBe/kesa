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
        'Spójność plików
        If My.Settings.adv_filesVerify = "True" Then
            bg_black.Show()
            integrityverifier.Show()
        Else
            loginscreen.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Animacja + uruchomienie panelu logowania
        Timer1.Stop()
        Timer2.Start()
        bg.Show()
        bg.Opacity = 0
    End Sub

    Private Sub bootstrap_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.R Then
            'Uruchomienie recovery
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If bg.Opacity = 1 Then
            Timer2.Stop()
            If installer = True Then
                Me.Hide()
                'odpalanie instalatora
                Cursor.Show()
            Else
                loginscreen.Show()
                Me.Hide()
                bg.Close()
                Cursor.Show()
            End If
        End If
        bg.Opacity = bg.Opacity + 0.05
    End Sub
End Class
