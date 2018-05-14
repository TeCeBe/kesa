Public Class about_pc
    Private Sub about_pc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' shows the processor name and speed of the computer
        Dim MyOBJ As Object
        Dim cpu As Object
        MyOBJ = GetObject("WinMgmts:").instancesof("Win32_Processor")
        For Each cpu In MyOBJ
            'cpu_info.Text = cpu.Name.ToString
        Next
    End Sub
End Class