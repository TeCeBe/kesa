<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about_pc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(about_pc))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.lstDisplayHardware = New System.Windows.Forms.ListView()
        Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(675, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(700, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Informacje o komputerze"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 7
        '
        'lstDisplayHardware
        '
        Me.lstDisplayHardware.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2})
        Me.lstDisplayHardware.Location = New System.Drawing.Point(12, 33)
        Me.lstDisplayHardware.Name = "lstDisplayHardware"
        Me.lstDisplayHardware.Size = New System.Drawing.Size(676, 357)
        Me.lstDisplayHardware.TabIndex = 6
        Me.lstDisplayHardware.UseCompatibleStateImageBehavior = False
        Me.lstDisplayHardware.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "Name"
        Me.columnHeader1.Width = 72
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Value"
        Me.columnHeader2.Width = 503
        '
        'about_pc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.lstDisplayHardware)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "about_pc"
        Me.Text = "about_pc"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Private WithEvents lstDisplayHardware As ListView
    Private WithEvents columnHeader1 As ColumnHeader
    Private WithEvents columnHeader2 As ColumnHeader
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
End Class
