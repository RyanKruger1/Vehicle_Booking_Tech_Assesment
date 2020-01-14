Imports System.Drawing

Public Class NewBookingForm


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nameDb As String = Name.Text
        Dim modelDb As String = model.Text
        Dim day As String = dtp.Value.ToString("yyyy-MM-dd")
        Dim nts As String = notes.Text
        Dim errorCheck As Boolean = False

        If nameDb.Trim.Equals("") Then
            MsgBox("You dont have a name entered")
            Name.ForeColor = Color.Red
            errorCheck = True


        ElseIf CheckIfStringHasNumber(nameDb) Then
            MsgBox("Hmmmmm.... Name seems to be invalid")
            errorCheck = True
            Name.ForeColor = Color.Red

        End If

        If modelDb.Trim.Equals("") Then
            MsgBox("You dont have a car model entered")
            model.ForeColor = Color.Red
            errorCheck = True

        ElseIf CheckIfStringHasNumber(modelDb) Then
            MsgBox("Hmmmmm.... Car model seems to be invalid")
            model.ForeColor = Color.Red
            errorCheck = True

        End If


        If errorCheck Then
            MsgBox("You seems to have errors in your form.")
        Else

            Dim database As New SQLServerInterface
            If database.InsertBooking(nameDb, modelDb, day, nts) Then
                MsgBox("Successfully created booking.")
                Me.Close()
            Else
                MsgBox("Oops something went wrong , please try again")
            End If

        End If



    End Sub

    Public Function CheckIfStringHasNumber(value As String)
        Dim charArray = value.ToCharArray()

        For a = 0 To charArray.Length - 1

            If (Not Char.IsLetter(charArray(a))) Then

                Return True

            End If

        Next

        Return False

    End Function
End Class