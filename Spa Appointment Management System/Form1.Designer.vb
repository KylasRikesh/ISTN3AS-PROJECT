<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.SubmenuPanel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AppointmentBtn = New System.Windows.Forms.Button()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.logoPanel = New System.Windows.Forms.PictureBox()
        Me.childPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuPanel.SuspendLayout()
        Me.SubmenuPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.logoPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.childPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuPanel.Controls.Add(Me.SubmenuPanel)
        Me.MenuPanel.Controls.Add(Me.AppointmentBtn)
        Me.MenuPanel.Controls.Add(Me.loginButton)
        Me.MenuPanel.Controls.Add(Me.Panel3)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(200, 600)
        Me.MenuPanel.TabIndex = 0
        '
        'SubmenuPanel
        '
        Me.SubmenuPanel.Controls.Add(Me.Button2)
        Me.SubmenuPanel.Controls.Add(Me.Button1)
        Me.SubmenuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubmenuPanel.Location = New System.Drawing.Point(0, 200)
        Me.SubmenuPanel.Name = "SubmenuPanel"
        Me.SubmenuPanel.Size = New System.Drawing.Size(200, 106)
        Me.SubmenuPanel.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(200, 50)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "   View"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(200, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "  Create"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AppointmentBtn
        '
        Me.AppointmentBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppointmentBtn.FlatAppearance.BorderSize = 0
        Me.AppointmentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.AppointmentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.AppointmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AppointmentBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppointmentBtn.ForeColor = System.Drawing.Color.Black
        Me.AppointmentBtn.Image = CType(resources.GetObject("AppointmentBtn.Image"), System.Drawing.Image)
        Me.AppointmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AppointmentBtn.Location = New System.Drawing.Point(0, 150)
        Me.AppointmentBtn.Name = "AppointmentBtn"
        Me.AppointmentBtn.Size = New System.Drawing.Size(200, 50)
        Me.AppointmentBtn.TabIndex = 2
        Me.AppointmentBtn.Text = "  Appointment"
        Me.AppointmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AppointmentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AppointmentBtn.UseVisualStyleBackColor = True
        '
        'loginButton
        '
        Me.loginButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.loginButton.FlatAppearance.BorderSize = 0
        Me.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginButton.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.ForeColor = System.Drawing.Color.Black
        Me.loginButton.Image = CType(resources.GetObject("loginButton.Image"), System.Drawing.Image)
        Me.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginButton.Location = New System.Drawing.Point(0, 100)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(200, 50)
        Me.loginButton.TabIndex = 1
        Me.loginButton.Text = "  Login"
        Me.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.logoPanel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 0
        '
        'logoPanel
        '
        Me.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.logoPanel.Image = CType(resources.GetObject("logoPanel.Image"), System.Drawing.Image)
        Me.logoPanel.InitialImage = CType(resources.GetObject("logoPanel.InitialImage"), System.Drawing.Image)
        Me.logoPanel.Location = New System.Drawing.Point(0, 0)
        Me.logoPanel.Name = "logoPanel"
        Me.logoPanel.Size = New System.Drawing.Size(200, 100)
        Me.logoPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoPanel.TabIndex = 0
        Me.logoPanel.TabStop = False
        '
        'childPanel
        '
        Me.childPanel.BackColor = System.Drawing.Color.White
        Me.childPanel.BackgroundImage = CType(resources.GetObject("childPanel.BackgroundImage"), System.Drawing.Image)
        Me.childPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.childPanel.Controls.Add(Me.Panel1)
        Me.childPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.childPanel.ForeColor = System.Drawing.Color.Black
        Me.childPanel.Location = New System.Drawing.Point(200, 0)
        Me.childPanel.Name = "childPanel"
        Me.childPanel.Size = New System.Drawing.Size(750, 600)
        Me.childPanel.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 33)
        Me.Panel1.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(696, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(27, 33)
        Me.Button4.TabIndex = 1
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(723, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 33)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(950, 600)
        Me.Controls.Add(Me.childPanel)
        Me.Controls.Add(Me.MenuPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuPanel.ResumeLayout(False)
        Me.SubmenuPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.logoPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.childPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuPanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents logoPanel As PictureBox
    Friend WithEvents childPanel As Panel
    Friend WithEvents loginButton As Button
    Friend WithEvents AppointmentBtn As Button
    Friend WithEvents SubmenuPanel As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
End Class
