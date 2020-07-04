<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppointmentDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppointmentDetails))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BunifuTextbox1 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.MetroDateTime2 = New MetroFramework.Controls.MetroDateTime()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuTextbox2 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuTextbox3 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Honeydew
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(992, 123)
        Me.Panel2.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Honeydew
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(398, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Items.AddRange(New Object() {"Scheduled", "No Show ", "Cancelled"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(-1, -1)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(347, 29)
        Me.MetroComboBox1.TabIndex = 13
        Me.MetroComboBox1.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(335, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Status"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.Gray
        Me.DateTimePicker1.CustomFormat = "hh : mm tt"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(-1, -2)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(350, 29)
        Me.DateTimePicker1.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(341, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 21)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuTextbox1
        '
        Me.BunifuTextbox1.BackColor = System.Drawing.Color.White
        Me.BunifuTextbox1.BackgroundImage = CType(resources.GetObject("BunifuTextbox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuTextbox1.Icon = CType(resources.GetObject("BunifuTextbox1.Icon"), System.Drawing.Image)
        Me.BunifuTextbox1.Location = New System.Drawing.Point(309, 179)
        Me.BunifuTextbox1.Name = "BunifuTextbox1"
        Me.BunifuTextbox1.Size = New System.Drawing.Size(405, 46)
        Me.BunifuTextbox1.TabIndex = 36
        Me.BunifuTextbox1.text = ""
        '
        'MetroDateTime2
        '
        Me.MetroDateTime2.DisplayFocus = True
        Me.MetroDateTime2.Location = New System.Drawing.Point(-2, -2)
        Me.MetroDateTime2.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime2.Name = "MetroDateTime2"
        Me.MetroDateTime2.Size = New System.Drawing.Size(347, 29)
        Me.MetroDateTime2.Style = MetroFramework.MetroColorStyle.White
        Me.MetroDateTime2.TabIndex = 38
        Me.MetroDateTime2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroDateTime2.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 21)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Time"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuTextbox2
        '
        Me.BunifuTextbox2.BackColor = System.Drawing.Color.White
        Me.BunifuTextbox2.BackgroundImage = CType(resources.GetObject("BunifuTextbox2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuTextbox2.Icon = CType(resources.GetObject("BunifuTextbox2.Icon"), System.Drawing.Image)
        Me.BunifuTextbox2.Location = New System.Drawing.Point(309, 266)
        Me.BunifuTextbox2.Name = "BunifuTextbox2"
        Me.BunifuTextbox2.Size = New System.Drawing.Size(405, 44)
        Me.BunifuTextbox2.TabIndex = 41
        Me.BunifuTextbox2.text = ""
        '
        'BunifuTextbox3
        '
        Me.BunifuTextbox3.BackColor = System.Drawing.Color.White
        Me.BunifuTextbox3.BackgroundImage = CType(resources.GetObject("BunifuTextbox3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuTextbox3.Icon = CType(resources.GetObject("BunifuTextbox3.Icon"), System.Drawing.Image)
        Me.BunifuTextbox3.Location = New System.Drawing.Point(307, 355)
        Me.BunifuTextbox3.Name = "BunifuTextbox3"
        Me.BunifuTextbox3.Size = New System.Drawing.Size(407, 54)
        Me.BunifuTextbox3.TabIndex = 42
        Me.BunifuTextbox3.text = ""
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = CType(resources.GetObject("GunaCircleButton1.Image"), System.Drawing.Image)
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(444, 434)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(120, 120)
        Me.GunaCircleButton1.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MetroDateTime2)
        Me.Panel1.Location = New System.Drawing.Point(353, 187)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(341, 26)
        Me.Panel1.TabIndex = 44
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Location = New System.Drawing.Point(353, 276)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(348, 26)
        Me.Panel3.TabIndex = 45
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.MetroComboBox1)
        Me.Panel4.Location = New System.Drawing.Point(353, 370)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(341, 26)
        Me.Panel4.TabIndex = 46
        '
        'AppointmentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(992, 658)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GunaCircleButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BunifuTextbox2)
        Me.Controls.Add(Me.BunifuTextbox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuTextbox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AppointmentDetails"
        Me.ShowIcon = False
        Me.Text = "AppointmentDetails"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents BunifuTextbox1 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents MetroDateTime2 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuTextbox2 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuTextbox3 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
