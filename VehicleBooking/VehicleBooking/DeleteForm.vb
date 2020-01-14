Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nameDb As String = Name.Text
        Dim modelDb As String = model.Text
        Dim day As String = dtp.Value.ToString("yyyy-MM-dd")
        Dim database As New Class1

        If database.DeleteBooking(nameDb, modelDb, day) Then
            MsgBox("Successfully deleted bookings")
            Me.Close()

        Else
            MsgBox("Could not find booking information. Please try again")
        End If


    End Sub
End Class