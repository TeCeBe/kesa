<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class musicplayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(musicplayer))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.shuffleon = New System.Windows.Forms.PictureBox()
        Me.repeaton = New System.Windows.Forms.PictureBox()
        Me.shuffleoff = New System.Windows.Forms.PictureBox()
        Me.repeatoff = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.BunifuSlider2 = New ns1.BunifuSlider()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuSlider1 = New ns1.BunifuSlider()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuFlatButton1 = New ns1.BunifuFlatButton()
        Me.BunifuFlatButton2 = New ns1.BunifuFlatButton()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.shuffleon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repeaton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shuffleoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repeatoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
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
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(30, 519)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 433)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(30, 86)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel3.Controls.Add(Me.shuffleon)
        Me.Panel3.Controls.Add(Me.repeaton)
        Me.Panel3.Controls.Add(Me.shuffleoff)
        Me.Panel3.Controls.Add(Me.repeatoff)
        Me.Panel3.Controls.Add(Me.PictureBox7)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox6)
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Controls.Add(Me.BunifuSlider2)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.BunifuSlider1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(30, 433)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(813, 86)
        Me.Panel3.TabIndex = 8
        '
        'shuffleon
        '
        Me.shuffleon.BackgroundImage = Global.KESA.My.Resources.Resources.player_shuffle
        Me.shuffleon.Location = New System.Drawing.Point(717, 15)
        Me.shuffleon.Name = "shuffleon"
        Me.shuffleon.Size = New System.Drawing.Size(24, 24)
        Me.shuffleon.TabIndex = 22
        Me.shuffleon.TabStop = False
        '
        'repeaton
        '
        Me.repeaton.BackgroundImage = Global.KESA.My.Resources.Resources.player_repeat
        Me.repeaton.Location = New System.Drawing.Point(747, 15)
        Me.repeaton.Name = "repeaton"
        Me.repeaton.Size = New System.Drawing.Size(24, 24)
        Me.repeaton.TabIndex = 21
        Me.repeaton.TabStop = False
        '
        'shuffleoff
        '
        Me.shuffleoff.BackgroundImage = Global.KESA.My.Resources.Resources.player_shuffle_off
        Me.shuffleoff.Location = New System.Drawing.Point(717, 15)
        Me.shuffleoff.Name = "shuffleoff"
        Me.shuffleoff.Size = New System.Drawing.Size(24, 24)
        Me.shuffleoff.TabIndex = 20
        Me.shuffleoff.TabStop = False
        '
        'repeatoff
        '
        Me.repeatoff.BackgroundImage = Global.KESA.My.Resources.Resources.player_repeat_off
        Me.repeatoff.Location = New System.Drawing.Point(747, 15)
        Me.repeatoff.Name = "repeatoff"
        Me.repeatoff.Size = New System.Drawing.Size(24, 24)
        Me.repeatoff.TabIndex = 19
        Me.repeatoff.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(777, 15)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox7.TabIndex = 18
        Me.PictureBox7.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(612, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "3:23"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(163, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "0:00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(85, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "The Chainsmokers"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(85, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "The Chainsmokers - Sick Boy"
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.KESA.My.Resources.Resources.player_speaker100
        Me.PictureBox5.Location = New System.Drawing.Point(680, 50)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'BunifuSlider2
        '
        Me.BunifuSlider2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSlider2.BackgroudColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.BunifuSlider2.BorderRadius = 0
        Me.BunifuSlider2.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuSlider2.Location = New System.Drawing.Point(710, 49)
        Me.BunifuSlider2.MaximumValue = 100
        Me.BunifuSlider2.Name = "BunifuSlider2"
        Me.BunifuSlider2.Size = New System.Drawing.Size(91, 30)
        Me.BunifuSlider2.TabIndex = 12
        Me.BunifuSlider2.Value = 0
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.KESA.My.Resources.Resources.player_rewindbtn
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(356, 15)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.KESA.My.Resources.Resources.player_forwardbtn
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(432, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.KESA.My.Resources.Resources.player_playbtn
        Me.PictureBox2.Location = New System.Drawing.Point(391, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'BunifuSlider1
        '
        Me.BunifuSlider1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSlider1.BackgroudColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.BunifuSlider1.BorderRadius = 0
        Me.BunifuSlider1.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuSlider1.Location = New System.Drawing.Point(199, 50)
        Me.BunifuSlider1.MaximumValue = 100
        Me.BunifuSlider1.Name = "BunifuSlider1"
        Me.BunifuSlider1.Size = New System.Drawing.Size(415, 28)
        Me.BunifuSlider1.TabIndex = 9
        Me.BunifuSlider1.Value = 50
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel4.Controls.Add(Me.BunifuFlatButton2)
        Me.Panel4.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(30, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(168, 433)
        Me.Panel4.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(147, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Home"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 51)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(168, 36)
        Me.BunifuFlatButton1.TabIndex = 10
        Me.BunifuFlatButton1.Text = "Home"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Open file"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(0, 93)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(168, 36)
        Me.BunifuFlatButton2.TabIndex = 11
        Me.BunifuFlatButton2.Text = "Open file"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'musicplayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(843, 519)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "musicplayer"
        Me.Text = "musicplayer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.shuffleon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repeaton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shuffleoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repeatoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuSlider1 As ns1.BunifuSlider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents BunifuSlider2 As ns1.BunifuSlider
    Friend WithEvents shuffleoff As PictureBox
    Friend WithEvents repeatoff As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents repeaton As PictureBox
    Friend WithEvents shuffleon As PictureBox
    Friend WithEvents BunifuFlatButton2 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As ns1.BunifuFlatButton
End Class
