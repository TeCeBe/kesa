<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shutdown
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(82, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(72, 72)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(170, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(72, 72)
        Me.Panel2.TabIndex = 1
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(345, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(72, 72)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(258, 60)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(72, 72)
        Me.Panel4.TabIndex = 2
        '
        'shutdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(498, 196)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "shutdown"
        Me.Opacity = 0.85R
        Me.Text = "shutdown"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
