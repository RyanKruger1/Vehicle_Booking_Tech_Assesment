Public Class DeleteBookingForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nameDb As String = Name.Text
        Dim modelDb As String = model.Text
        Dim day As String = dtp.Value.ToString("yyyy-MM-dd")
        Dim database As New SQLServerInterface

        If database.DeleteBooking(nameDb, modelDb, day) Then
            MsgBox("Successfully deleted bookings")
            Me.Close()

        Else
            MsgBox("Could not find booking information. Please try again")
        End If


    End Sub
End Class