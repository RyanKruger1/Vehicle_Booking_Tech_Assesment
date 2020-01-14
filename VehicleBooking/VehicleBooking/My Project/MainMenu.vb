Imports System.Data

Public Class MainMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nbf As New NewBookingForm
        nbf.Show()


        'Update Table
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bookings.Text = ""

        Dim dt As String
        dt = dtp1.Value
        Dim actualDate = dt.Split(" ")(0).Replace("/", "-") ' Gets the  date selected in format yyyy/mm/dd

        Dim c As New SQLServerInterface
        Dim data As New DataTable
        Dim appendString As String = ""

        data = c.RetreiveRecordsOfACertainDate(actualDate) ' Retrieves Data from the database according to the selected date

        'Checks if there is data present if not , it wil just display a  message
        If data.Rows.Count > 0 Then

            'Creates the headers to organise data
            appendString = data.Columns(0).ToString()

            For col = 1 To data.Columns.Count - 1
                appendString = appendString + "   " + data.Columns(col).ToString()

            Next

            bookings.AppendText(appendString & vbCrLf)

            'uses data to populate the text area.
            For a = 0 To data.Rows.Count - 1

                Dim dr As DataRow

                dr = data.Rows(a)

                appendString = dr(0).ToString() + "   "

                For b = 1 To data.Columns.Count - 1

                    appendString = appendString + "   " + dr(b).ToString()

                Next
                ' Writes string to the text area
                bookings.AppendText(appendString & vbCrLf)

            Next
        Else
            bookings.AppendText("No bookings requested")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bookings.Text = ""

        Dim dt As String
        dt = dtp1.Value
        Dim actualDate = dt.Split(" ")(0).Replace("/", "-") ' Gets the  date selected in format yyyy/mm/dd

        Dim c As New SQLServerInterface
        Dim data As New DataTable
        Dim appendString As String = ""

        data = c.RetreiveAllDueBookings() ' Retrieves Data from the database according to the selected date

        'Checks if there is data present if not , it wil just display a  message
        If data.Rows.Count > 0 Then

            'Creates the headers to organise data
            appendString = data.Columns(0).ToString()

            For col = 1 To data.Columns.Count - 1
                appendString = appendString + "   " + data.Columns(col).ToString()

            Next

            bookings.AppendText(appendString & vbCrLf)

            'uses data to populate the text area.
            For a = 0 To data.Rows.Count - 1

                Dim dr As DataRow

                dr = data.Rows(a)

                appendString = dr(0).ToString() + "   "

                For b = 1 To data.Columns.Count - 1

                    appendString = appendString + "   " + dr(b).ToString()

                Next
                ' Writes string to the text area
                bookings.AppendText(appendString & vbCrLf)

            Next
        Else
            bookings.AppendText("No bookings requested")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles completed.Click
        bookings.Text = ""

        Dim dt As String
        dt = dtp1.Value
        Dim actualDate = dt.Split(" ")(0).Replace("/", "-") ' Gets the  date selected in format yyyy/mm/dd

        Dim c As New SQLServerInterface
        Dim data As New DataTable
        Dim appendString As String = ""

        data = c.RetreiveAllCompletedBookings() ' Retrieves Data from the database according to the selected date

        'Checks if there is data present if not , it wil just display a  message
        If data.Rows.Count > 0 Then

            'Creates the headers to organise data
            appendString = data.Columns(0).ToString()

            For col = 1 To data.Columns.Count - 1
                appendString = appendString + "   " + data.Columns(col).ToString()

            Next

            bookings.AppendText(appendString & vbCrLf)

            'uses data to populate the text area.
            For a = 0 To data.Rows.Count - 1

                Dim dr As DataRow

                dr = data.Rows(a)

                appendString = dr(0).ToString() + "   "

                For b = 1 To data.Columns.Count - 1

                    appendString = appendString + "   " + dr(b).ToString()

                Next
                ' Writes string to the text area
                bookings.AppendText(appendString & vbCrLf)

            Next
        Else
            bookings.AppendText("No bookings requested")
        End If

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nbf As New DeleteBookingForm
        nbf.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        bookings.Text = ""

        Dim dt As String
        dt = dtp1.Value
        Dim actualDate = dt.Split(" ")(0).Replace("/", "-") ' Gets the  date selected in format yyyy/mm/dd

        Dim c As New SQLServerInterface
        Dim data As New DataTable
        Dim appendString As String = ""

        data = c.RetreiveAllBookings() ' Retrieves Data from the database according to the selected date

        'Checks if there is data present if not , it wil just display a  message
        If data.Rows.Count > 0 Then

            'Creates the headers to organise data
            appendString = data.Columns(0).ToString()

            For col = 1 To data.Columns.Count - 1
                appendString = appendString + "   " + data.Columns(col).ToString()

            Next

            bookings.AppendText(appendString & vbCrLf)

            'uses data to populate the text area.
            For a = 0 To data.Rows.Count - 1

                Dim dr As DataRow

                dr = data.Rows(a)

                appendString = dr(0).ToString() + "   "

                For b = 1 To data.Columns.Count - 1

                    appendString = appendString + "   " + dr(b).ToString()

                Next
                ' Writes string to the text area
                bookings.AppendText(appendString & vbCrLf)

            Next
        Else
            bookings.AppendText("No bookings requested")
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim nbf As New EditForm
        nbf.Show()

    End Sub
End Class