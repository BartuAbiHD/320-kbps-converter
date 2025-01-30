<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class converter_program
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(converter_program))
        Me.fileName = New MonoFlat.t_TextBox()
        Me.Button1 = New MonoFlat.Button()
        Me.T_Label1 = New MonoFlat.t_Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ControlBox1 = New MonoFlat.ControlBox()
        Me.ThemeContainer1 = New MonoFlat.ThemeContainer()
        Me.fileName2 = New MonoFlat.t_TextBox()
        Me.T_Label2 = New MonoFlat.t_Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fileName
        '
        Me.fileName.BackColor = System.Drawing.Color.Transparent
        Me.fileName.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.fileName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.fileName.Image = Nothing
        Me.fileName.Location = New System.Drawing.Point(6, 66)
        Me.fileName.MaxLength = 32767
        Me.fileName.Multiline = False
        Me.fileName.Name = "fileName"
        Me.fileName.ReadOnly = False
        Me.fileName.Size = New System.Drawing.Size(335, 23)
        Me.fileName.TabIndex = 1
        Me.fileName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.fileName.UseSystemPasswordChar = False
        Me.fileName.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Image = Nothing
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(96, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 41)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "CONVERT"
        Me.Button1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'T_Label1
        '
        Me.T_Label1.AutoSize = True
        Me.T_Label1.BackColor = System.Drawing.Color.Transparent
        Me.T_Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.T_Label1.ForeColor = System.Drawing.Color.White
        Me.T_Label1.Location = New System.Drawing.Point(93, 142)
        Me.T_Label1.Name = "T_Label1"
        Me.T_Label1.Size = New System.Drawing.Size(159, 15)
        Me.T_Label1.TabIndex = 3
        Me.T_Label1.Text = "Programmed by BartuAbiHD"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(248, 143)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(99, 16)
        Me.Panel1.TabIndex = 4
        '
        'ControlBox1
        '
        Me.ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBox1.EnableHoverHighlight = False
        Me.ControlBox1.EnableMaximizeButton = False
        Me.ControlBox1.EnableMinimizeButton = True
        Me.ControlBox1.Location = New System.Drawing.Point(235, 15)
        Me.ControlBox1.Name = "ControlBox1"
        Me.ControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.ControlBox1.TabIndex = 5
        Me.ControlBox1.Text = "ControlBox1"
        '
        'ThemeContainer1
        '
        Me.ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThemeContainer1.Controls.Add(Me.fileName2)
        Me.ThemeContainer1.Controls.Add(Me.T_Label2)
        Me.ThemeContainer1.Controls.Add(Me.ControlBox1)
        Me.ThemeContainer1.Controls.Add(Me.Panel1)
        Me.ThemeContainer1.Controls.Add(Me.T_Label1)
        Me.ThemeContainer1.Controls.Add(Me.Button1)
        Me.ThemeContainer1.Controls.Add(Me.fileName)
        Me.ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ThemeContainer1.Name = "ThemeContainer1"
        Me.ThemeContainer1.Padding = New System.Windows.Forms.Padding(10, 70, 10, 9)
        Me.ThemeContainer1.RoundCorners = True
        Me.ThemeContainer1.Sizable = True
        Me.ThemeContainer1.Size = New System.Drawing.Size(347, 162)
        Me.ThemeContainer1.SmartBounds = True
        Me.ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ThemeContainer1.TabIndex = 0
        Me.ThemeContainer1.Text = "320 kbps converter"
        '
        'fileName2
        '
        Me.fileName2.BackColor = System.Drawing.Color.Transparent
        Me.fileName2.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.fileName2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.fileName2.Image = Nothing
        Me.fileName2.Location = New System.Drawing.Point(6, 91)
        Me.fileName2.MaxLength = 32767
        Me.fileName2.Multiline = False
        Me.fileName2.Name = "fileName2"
        Me.fileName2.ReadOnly = False
        Me.fileName2.Size = New System.Drawing.Size(335, 23)
        Me.fileName2.TabIndex = 7
        Me.fileName2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.fileName2.UseSystemPasswordChar = False
        Me.fileName2.Visible = False
        '
        'T_Label2
        '
        Me.T_Label2.AutoSize = True
        Me.T_Label2.BackColor = System.Drawing.Color.Transparent
        Me.T_Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.T_Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.T_Label2.Location = New System.Drawing.Point(3, 144)
        Me.T_Label2.Name = "T_Label2"
        Me.T_Label2.Size = New System.Drawing.Size(28, 15)
        Me.T_Label2.TabIndex = 6
        Me.T_Label2.Text = "v1.2"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'converter_program
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(347, 162)
        Me.Controls.Add(Me.ThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "converter_program"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "320 kbps converter"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ThemeContainer1.ResumeLayout(False)
        Me.ThemeContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fileName As MonoFlat.t_TextBox
    Friend WithEvents Button1 As MonoFlat.Button
    Friend WithEvents T_Label1 As MonoFlat.t_Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ControlBox1 As MonoFlat.ControlBox
    Friend WithEvents ThemeContainer1 As MonoFlat.ThemeContainer
    Friend WithEvents T_Label2 As MonoFlat.t_Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents fileName2 As MonoFlat.t_TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
