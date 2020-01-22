Imports System.Drawing
Imports System.IO

Public Class NewBookingForm


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nameDb As String = Name.Text
        Dim modelDb As String = listbox.GetSelected(1)

        Dim day As String = dtp.Value.ToString("yyyy-MM-dd")
        Dim nts As String = notes.Text
        Dim errorCheck As Boolean = False
        Dim model As Object = listbox.SelectedItem
        Dim modelStr As String = modelDb.ToString



        If nameDb.Trim.Equals("") Then
            MsgBox("You dont have a name entered")
            Name.ForeColor = Color.Red
            errorCheck = True


        ElseIf CheckIfStringHasNumber(nameDb) Then
            MsgBox("Hmmmmm.... Name seems to be invalid")
            errorCheck = True
            Name.ForeColor = Color.Red

        End If



        If errorCheck Then
            MsgBox("You seems to have errors in your form.")
        Else

            Dim database As New SQLServerInterface
            If database.InsertBooking(nameDb, model, day, nts) Then
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

    Public Function getModels() As Array

        Dim TextFilePath As String = IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cars.txt")
        Dim r As StreamReader
        r = New StreamReader(TextFilePath)

        Dim textFile As String = r.ReadLine()
        Dim cars As Array
        cars = textFile.Split(",")

        Return cars
    End Function

End Class