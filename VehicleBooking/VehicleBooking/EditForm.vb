Public Class EditForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nameDb As String = Name.Text
        Dim modelDb As String = model.Text.ToUpper
        Dim day As String = dtp.Value.ToString("yyyy-MM-dd")
        Dim database As New SQLServerInterface

        If database.DeleteBooking(nameDb, modelDb, day) Then
            MsgBox("Successfully found bookings. Please update to new details")
            Button1.Visible = False
            Button2.Visible = True
            Name.Enabled = False

        Else
            MsgBox("Could not find booking information. Please try again")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim nameDb As String = Name.Text
        Dim modelDb As String = model.Text.ToUpper
        Dim day As String = dtp.Value.ToString("yyyy-MM-dd")
        Dim nts As String = notes.Text

        Dim database As New SQLServerInterface
        If database.InsertBooking(nameDb, modelDb, day, nts) Then
            MsgBox("Successfully updated booking.")
            Me.Close()
        Else
            MsgBox("Oops something went wrong , please try again")
        End If

    End Sub
End Class