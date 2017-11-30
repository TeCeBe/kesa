Public Class authorizationform
    Private Sub authorizationform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loggeduser As String = My.Computer.FileSystem.ReadAllText("C:\Kesa\loggeduser.ini")
        'Odczytywanie hasła z pliku
        My.Computer.FileSystem.ReadAllText("C:\KESA\users\" + loggeduser + "\password.conf")
    End Sub
End Class