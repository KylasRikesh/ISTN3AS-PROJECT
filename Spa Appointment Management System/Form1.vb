﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub hideSubmenu()
        SubmenuPanel.Visible = False
    End Sub
    Private Sub showSubmenu(ByVal submenu)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub
    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        childPanel.Controls.Add(childForm)
        childPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles logoPanel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        openChildForm(New loginForm())
        hideSubmenu()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        openChildForm(New Appointment())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub childPanel_Paint(sender As Object, e As PaintEventArgs) Handles childPanel.Paint

    End Sub

    Private Sub AppointmentBtn_Click(sender As Object, e As EventArgs) Handles AppointmentBtn.Click
        showSubmenu(SubmenuPanel)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openChildForm(New view_appointment())
    End Sub
End Class
