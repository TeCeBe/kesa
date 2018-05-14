<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class errorscreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(errorscreen))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.process = New System.Windows.Forms.Label()
        Me.desc = New System.Windows.Forms.Label()
        Me.errorcode = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.process)
        Me.Panel1.Controls.Add(Me.desc)
        Me.Panel1.Controls.Add(Me.errorcode)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 361)
        Me.Panel1.TabIndex = 0
        '
        'process
        '
        Me.process.AutoSize = True
        Me.process.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.process.ForeColor = System.Drawing.Color.White
        Me.process.Location = New System.Drawing.Point(199, 246)
        Me.process.Name = "process"
        Me.process.Size = New System.Drawing.Size(40, 19)
        Me.process.TabIndex = 8
        Me.process.Text = "/core"
        '
        'desc
        '
        Me.desc.AutoSize = True
        Me.desc.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.desc.ForeColor = System.Drawing.Color.White
        Me.desc.Location = New System.Drawing.Point(199, 227)
        Me.desc.Name = "desc"
        Me.desc.Size = New System.Drawing.Size(83, 19)
        Me.desc.TabIndex = 7
        Me.desc.Text = "no jakoś tak"
        '
        'errorcode
        '
        Me.errorcode.AutoSize = True
        Me.errorcode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.errorcode.ForeColor = System.Drawing.Color.White
        Me.errorcode.Location = New System.Drawing.Point(199, 208)
        Me.errorcode.Name = "errorcode"
        Me.errorcode.Size = New System.Drawing.Size(17, 19)
        Me.errorcode.TabIndex = 6
        Me.errorcode.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(110, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Proces:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(110, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Opis:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(110, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kod błędu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(110, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(353, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kesa napotkała problem. Aby kontynuować pracę," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "należy uruchomić Kesę ponownie."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(236, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'errorscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(574, 363)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "errorscreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "errorscreen"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents process As Label
    Friend WithEvents desc As Label
    Friend WithEvents errorcode As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
