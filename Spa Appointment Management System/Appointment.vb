Public Class Appointment
    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        AppChildPnl.Controls.Add(childForm)
        AppChildPnl.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openChildForm(New Customer())
    End Sub

    Private Sub AppChildPnl_Paint(sender As Object, e As PaintEventArgs) Handles AppChildPnl.Paint

    End Sub

    Private Sub btnApp_Click(sender As Object, e As EventArgs) Handles btnApp.Click
        openChildForm(New AppointmentDetails())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        openChildForm(New ProductForm())
    End Sub
End Class