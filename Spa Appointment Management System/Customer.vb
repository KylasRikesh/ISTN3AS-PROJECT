Public Class Customer
    Private Sub customer(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sr As IO.StreamReader = Nothing
        Dim MyContents As New AutoCompleteStringCollection()
        If IO.File.Exists("C:\Users\Student\Documents\visual studio 2015\Projects\Spa Appointment Management System\Spa Appointment Management System\Spa Appointment Management System\bin\cities.txt") Then
            sr = IO.File.OpenText("C:\Users\Student\Documents\visual studio 2015\Projects\Spa Appointment Management System\Spa Appointment Management System\Spa Appointment Management System\bin\cities.txt")
            While Not sr.EndOfStream
                MyContents.Add(sr.ReadLine)
            End While
            sr.Close()
        End If
        TextBox2.AutoCompleteCustomSource = MyContents
        TextBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        TextBox2.AutoCompleteSource = AutoCompleteSource.CustomSource


        Dim lst As New List(Of String)

        'AutoComplete collection that will help to filter keep the records.
        Dim MySource As New AutoCompleteStringCollection()
        lst.Add("Kwa Zulu Natal")
        lst.Add("Limpopo")
        lst.Add("Gauteng")
        lst.Add("Free State")
        lst.Add("Mpumalanga")
        lst.Add("Limpopo")
        lst.Add("North West")
        lst.Add("Limpopo")
        lst.Add("Eastern Cape")
        lst.Add("Western Cape")
        lst.Add("Northern Cape")




        'Records binded to the AutocompleteStringCollection.
        MySource.AddRange(lst.ToArray)

        'this AutocompleteStringcollection binded to the textbox as custom
        'source.
        TextBox1.AutoCompleteCustomSource = MySource

        'Auto complete mode set to suggest append so that it will sugesst one
        'or more suggested completion strings it has bith ‘Suggest’ and
        '‘Append’ functionality
        TextBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        'Set to Custom source we have filled already
        TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub





    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub



    Private Sub MetroTabPage1_Enter(sender As Object, e As EventArgs) Handles MetroTabPage1.Enter
        GroupBox1.Show()
        GroupBox2.Hide()

        GroupBox3.Hide()
        GroupBox4.Hide()

    End Sub



    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        GroupBox1.Hide()
        GroupBox3.Hide()
        GroupBox4.Hide()
        GroupBox2.Show()
    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        GroupBox2.Hide()
        GroupBox1.Hide()
        GroupBox4.Hide()
        GroupBox3.Show()
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBox4.Hide()
        GroupBox1.Show()
    End Sub

    Private Sub GunaCircleButton3_Click(sender As Object, e As EventArgs) Handles btnPrevious2.Click

        GroupBox1.Hide()
        GroupBox3.Hide()
        GroupBox4.Hide()
        GroupBox2.Show()
    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click
        GroupBox1.Hide()
        GroupBox3.Hide()
        GroupBox2.Hide()

        GroupBox4.Location = New Point(182, 101)
        GroupBox4.Show()




    End Sub

    Private Sub GunaCircleButton3_Click_1(sender As Object, e As EventArgs) Handles GunaCircleButton3.Click

    End Sub

    Private Sub GunaCircleButton4_Click(sender As Object, e As EventArgs) Handles GunaCircleButton4.Click
        GroupBox1.Hide()
        GroupBox3.Show()
        GroupBox2.Hide()
        GroupBox4.Hide()
    End Sub
End Class
