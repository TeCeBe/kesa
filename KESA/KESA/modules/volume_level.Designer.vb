<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class volume_level
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New ns1.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuVTrackbar1 = New ns1.BunifuVTrackbar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 7
        Me.BunifuElipse2.TargetControl = Me.Panel1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuVTrackbar1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(61, 132)
        Me.Panel1.TabIndex = 0
        '
        'BunifuVTrackbar1
        '
        Me.BunifuVTrackbar1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuVTrackbar1.BackgroudColor = System.Drawing.Color.DimGray
        Me.BunifuVTrackbar1.BorderRadius = 0
        Me.BunifuVTrackbar1.IndicatorColor = System.Drawing.Color.LimeGreen
        Me.BunifuVTrackbar1.Location = New System.Drawing.Point(15, 12)
        Me.BunifuVTrackbar1.MaximumValue = 100
        Me.BunifuVTrackbar1.Name = "BunifuVTrackbar1"
        Me.BunifuVTrackbar1.Size = New System.Drawing.Size(30, 108)
        Me.BunifuVTrackbar1.SliderRadius = 0
        Me.BunifuVTrackbar1.TabIndex = 0
        Me.BunifuVTrackbar1.Value = 0
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'volume_level
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(61, 160)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "volume_level"
        Me.Text = "volume_level"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents BunifuElipse2 As ns1.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuVTrackbar1 As ns1.BunifuVTrackbar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
