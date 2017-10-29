<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginscreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginscreen))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuDropdown1 = New ns1.BunifuDropdown()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.BunifuThinButton21 = New ns1.BunifuThinButton2()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.clocklabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lockbutton = New ns1.BunifuTileButton()
        Me.shutdownbutton = New ns1.BunifuTileButton()
        Me.restartbutton = New ns1.BunifuTileButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuDropdown2 = New ns1.BunifuDropdown()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(12, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(844, 29)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nieprawidłowe hasło."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BunifuDropdown2)
        Me.Panel1.Controls.Add(Me.BunifuDropdown1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 162)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(868, 231)
        Me.Panel1.TabIndex = 16
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown1.BorderRadius = 0
        Me.BunifuDropdown1.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown1.Items = New String(-1) {}
        Me.BunifuDropdown1.Location = New System.Drawing.Point(364, 134)
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuDropdown1.selectedIndex = -1
        Me.BunifuDropdown1.Size = New System.Drawing.Size(146, 30)
        Me.BunifuDropdown1.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(381, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 110)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(149, 76)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(146, 33)
        Me.ComboBox1.TabIndex = 16
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(516, 170)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox6.TabIndex = 14
        Me.PictureBox6.TabStop = False
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 26
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.DimGray
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.White
        Me.BunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Zaloguj"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 26
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton21.Location = New System.Drawing.Point(381, 164)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(110, 37)
        Me.BunifuThinButton21.TabIndex = 12
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TextBox1.Location = New System.Drawing.Point(363, 170)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox1.Size = New System.Drawing.Size(147, 25)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'clocklabel
        '
        Me.clocklabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clocklabel.AutoSize = True
        Me.clocklabel.BackColor = System.Drawing.Color.Transparent
        Me.clocklabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.clocklabel.ForeColor = System.Drawing.Color.White
        Me.clocklabel.Location = New System.Drawing.Point(813, 6)
        Me.clocklabel.Name = "clocklabel"
        Me.clocklabel.Size = New System.Drawing.Size(49, 20)
        Me.clocklabel.TabIndex = 17
        Me.clocklabel.Text = "21:37"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox4.Location = New System.Drawing.Point(709, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(741, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(773, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 20)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'lockbutton
        '
        Me.lockbutton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lockbutton.BackColor = System.Drawing.Color.Transparent
        Me.lockbutton.color = System.Drawing.Color.Transparent
        Me.lockbutton.colorActive = System.Drawing.Color.Transparent
        Me.lockbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lockbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lockbutton.ForeColor = System.Drawing.Color.White
        Me.lockbutton.Image = CType(resources.GetObject("lockbutton.Image"), System.Drawing.Image)
        Me.lockbutton.ImagePosition = 13
        Me.lockbutton.ImageZoom = 42
        Me.lockbutton.LabelPosition = 18
        Me.lockbutton.LabelText = "Lock"
        Me.lockbutton.Location = New System.Drawing.Point(327, 6)
        Me.lockbutton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lockbutton.Name = "lockbutton"
        Me.lockbutton.Size = New System.Drawing.Size(70, 65)
        Me.lockbutton.TabIndex = 7
        '
        'shutdownbutton
        '
        Me.shutdownbutton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.shutdownbutton.BackColor = System.Drawing.Color.Transparent
        Me.shutdownbutton.color = System.Drawing.Color.Transparent
        Me.shutdownbutton.colorActive = System.Drawing.Color.Transparent
        Me.shutdownbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.shutdownbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.shutdownbutton.ForeColor = System.Drawing.Color.White
        Me.shutdownbutton.Image = CType(resources.GetObject("shutdownbutton.Image"), System.Drawing.Image)
        Me.shutdownbutton.ImagePosition = 13
        Me.shutdownbutton.ImageZoom = 42
        Me.shutdownbutton.LabelPosition = 18
        Me.shutdownbutton.LabelText = "Shutdown"
        Me.shutdownbutton.Location = New System.Drawing.Point(472, 6)
        Me.shutdownbutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.shutdownbutton.Name = "shutdownbutton"
        Me.shutdownbutton.Size = New System.Drawing.Size(70, 65)
        Me.shutdownbutton.TabIndex = 6
        '
        'restartbutton
        '
        Me.restartbutton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.restartbutton.BackColor = System.Drawing.Color.Transparent
        Me.restartbutton.color = System.Drawing.Color.Transparent
        Me.restartbutton.colorActive = System.Drawing.Color.Transparent
        Me.restartbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.restartbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.restartbutton.ForeColor = System.Drawing.Color.White
        Me.restartbutton.Image = CType(resources.GetObject("restartbutton.Image"), System.Drawing.Image)
        Me.restartbutton.ImagePosition = 13
        Me.restartbutton.ImageZoom = 42
        Me.restartbutton.LabelPosition = 18
        Me.restartbutton.LabelText = "Restart"
        Me.restartbutton.Location = New System.Drawing.Point(399, 6)
        Me.restartbutton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.restartbutton.Name = "restartbutton"
        Me.restartbutton.Size = New System.Drawing.Size(70, 65)
        Me.restartbutton.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.restartbutton)
        Me.Panel2.Controls.Add(Me.shutdownbutton)
        Me.Panel2.Controls.Add(Me.lockbutton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 470)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(868, 80)
        Me.Panel2.TabIndex = 21
        '
        'BunifuDropdown2
        '
        Me.BunifuDropdown2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown2.BorderRadius = 3
        Me.BunifuDropdown2.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown2.Items = New String(-1) {}
        Me.BunifuDropdown2.Location = New System.Drawing.Point(550, 108)
        Me.BunifuDropdown2.Name = "BunifuDropdown2"
        Me.BunifuDropdown2.NomalColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuDropdown2.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuDropdown2.selectedIndex = -1
        Me.BunifuDropdown2.Size = New System.Drawing.Size(217, 35)
        Me.BunifuDropdown2.TabIndex = 18
        '
        'loginscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(868, 550)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.clocklabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginscreen"
        Me.Text = "loginscreen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lockbutton As ns1.BunifuTileButton
    Friend WithEvents shutdownbutton As ns1.BunifuTileButton
    Friend WithEvents restartbutton As ns1.BunifuTileButton
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents BunifuThinButton21 As ns1.BunifuThinButton2
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents clocklabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BunifuDropdown1 As ns1.BunifuDropdown
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuDropdown2 As ns1.BunifuDropdown
End Class
