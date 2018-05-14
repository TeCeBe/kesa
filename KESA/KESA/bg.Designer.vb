<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bg
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bg))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.errorcode = New System.Windows.Forms.Label()
        Me.desc = New System.Windows.Forms.Label()
        Me.process = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "%str_build%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "%str_version%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "%str_status%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = " "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(320, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = """forceshutdown"" occured in /core/kernel"
        '
        'errorcode
        '
        Me.errorcode.AutoSize = True
        Me.errorcode.BackColor = System.Drawing.Color.Black
        Me.errorcode.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.errorcode.ForeColor = System.Drawing.Color.White
        Me.errorcode.Location = New System.Drawing.Point(12, 89)
        Me.errorcode.Name = "errorcode"
        Me.errorcode.Size = New System.Drawing.Size(104, 16)
        Me.errorcode.TabIndex = 5
        Me.errorcode.Text = "error_code 0"
        '
        'desc
        '
        Me.desc.AutoSize = True
        Me.desc.BackColor = System.Drawing.Color.Black
        Me.desc.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.desc.ForeColor = System.Drawing.Color.White
        Me.desc.Location = New System.Drawing.Point(12, 105)
        Me.desc.Name = "desc"
        Me.desc.Size = New System.Drawing.Size(144, 16)
        Me.desc.TabIndex = 6
        Me.desc.Text = "desc no jakoś tak"
        '
        'process
        '
        Me.process.AutoSize = True
        Me.process.BackColor = System.Drawing.Color.Black
        Me.process.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.process.ForeColor = System.Drawing.Color.White
        Me.process.Location = New System.Drawing.Point(12, 121)
        Me.process.Name = "process"
        Me.process.Size = New System.Drawing.Size(112, 16)
        Me.process.TabIndex = 7
        Me.process.Text = "process /core"
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(400, 287)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'bg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 371)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.process)
        Me.Controls.Add(Me.desc)
        Me.Controls.Add(Me.errorcode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bg"
        Me.Opacity = 0.8R
        Me.Text = "bg"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents errorcode As Label
    Friend WithEvents desc As Label
    Friend WithEvents process As Label
    Friend WithEvents PictureBox5 As PictureBox
End Class
