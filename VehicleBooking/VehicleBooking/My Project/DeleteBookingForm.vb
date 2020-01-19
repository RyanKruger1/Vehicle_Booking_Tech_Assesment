Public Class DeleteBookingForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim id As String = identification.Text

        Dim nme As String = Name.Text

        Dim db As New SQLServerInterface

        If db.DeleteBookingWithID(id, nme) Then
            MsgBox("Successfully deleted booking with id: " + id)
        Else
            MsgBox("Could booking was not found")
        End If



    End Sub
End Class