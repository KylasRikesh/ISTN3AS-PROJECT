Public Class view_appointment
    Private Sub view_appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateLabel.Text = Today()
    End Sub

    Private Sub GunaImageButton2_MouseHover(sender As Object, e As EventArgs) Handles GunaImageButton2.MouseHover
        GunaImageButton2.BackColor = Color.Honeydew
    End Sub

    Private Sub GunaImageButton1_MouseHover(sender As Object, e As EventArgs) Handles GunaImageButton1.MouseHover
        GunaImageButton1.BackColor = Color.Honeydew
    End Sub

    Private Sub GunaImageButton2_MouseLeave(sender As Object, e As EventArgs) Handles GunaImageButton2.MouseLeave
        GunaImageButton2.BackColor = Color.White
    End Sub

    Private Sub GunaImageButton1_MouseLeave(sender As Object, e As EventArgs) Handles GunaImageButton1.MouseLeave
        GunaImageButton1.BackColor = Color.White
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        view_appointment.Scr
    End Sub
End Class