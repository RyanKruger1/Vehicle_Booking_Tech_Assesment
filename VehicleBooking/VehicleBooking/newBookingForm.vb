Public Class NewBookingForm


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nameDb As String = Name.Text
        Dim modelDb As String = model.Text
        Dim day As String = dtp.Value.ToString("yyyy-MM-dd")
        Dim nts As String = notes.Text

        Dim database As New Class1
        If database.InsertBooking(nameDb, modelDb, day, nts) Then
            MsgBox("Successfully created booking.")
            Me.Close()
        Else
            MsgBox("Oops something went wrong , please try again")
        End If


    End Sub
End Class