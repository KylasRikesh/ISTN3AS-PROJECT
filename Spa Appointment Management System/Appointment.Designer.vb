<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Appointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Appointment))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnApp = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AppChildPnl = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.btnApp)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 62)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.Honeydew
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(675, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(360, 62)
        Me.Button3.TabIndex = 2
        Me.ToolTip3.SetToolTip(Me.Button3, "Service/Product")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnApp
        '
        Me.btnApp.AutoSize = True
        Me.btnApp.BackColor = System.Drawing.Color.Honeydew
        Me.btnApp.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnApp.FlatAppearance.BorderSize = 0
        Me.btnApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApp.Image = CType(resources.GetObject("btnApp.Image"), System.Drawing.Image)
        Me.btnApp.Location = New System.Drawing.Point(336, 0)
        Me.btnApp.Name = "btnApp"
        Me.btnApp.Size = New System.Drawing.Size(339, 62)
        Me.btnApp.TabIndex = 1
        Me.ToolTip2.SetToolTip(Me.btnApp, "Appointment Details")
        Me.btnApp.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(336, 62)
        Me.Button1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Button1, "Customer Details")
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 5000
        Me.ToolTip1.AutoPopDelay = 50000
        Me.ToolTip1.BackColor = System.Drawing.Color.LightYellow
        Me.ToolTip1.InitialDelay = 1
        Me.ToolTip1.ReshowDelay = 1000
        Me.ToolTip1.ShowAlways = True
        '
        'ToolTip2
        '
        Me.ToolTip2.AutoPopDelay = 5000
        Me.ToolTip2.InitialDelay = 1
        Me.ToolTip2.ReshowDelay = 100
        '
        'ToolTip3
        '
        Me.ToolTip3.AutoPopDelay = 5000
        Me.ToolTip3.InitialDelay = 1
        Me.ToolTip3.ReshowDelay = 100
        '
        'AppChildPnl
        '
        Me.AppChildPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppChildPnl.Location = New System.Drawing.Point(0, 62)
        Me.AppChildPnl.Name = "AppChildPnl"
        Me.AppChildPnl.Size = New System.Drawing.Size(734, 499)
        Me.AppChildPnl.TabIndex = 1
        '
        'Appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(734, 561)
        Me.Controls.Add(Me.AppChildPnl)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Appointment"
        Me.Text = "Appointment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents btnApp As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents AppChildPnl As Panel
End Class
