Imports System.Data
Imports System.Windows.Forms

Public Class MainMenu


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nbf As New NewBookingForm
        nbf.Show()


        'Update Table
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim dt As String
        dt = dtp1.Value
        Dim actualDate = dt.Split(" ")(0).Replace("/", "-") ' Gets the  date selected in format yyyy/mm/dd

        Dim c As New SQLServerInterface
        Dim data As New DataTable
        Dim appendString As String = ""
        Dim source As New BindingSource
        data = c.RetreiveRecordsOfACertainDate(actualDate) ' Retrieves Data from the database according to the selected date

        'Checks if there is data present if not , it wil just display a  message
        source.DataSource = data
        GridView1.DataSource = source

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim dt As String
        dt = dtp1.Value
        Dim actualDate = dt.Split(" ")(0).Replace("/", "-") ' Gets the  date selected in format yyyy/mm/dd

        Dim c As New SQLServerInterface
        Dim data As New DataTable
        Dim appendString As String = ""
        Dim source As New BindingSource

        data = c.RetreiveAllDueBookings()
        source.DataSource = data
        GridView1.DataSource = source


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles completed.Click


        Dim dt As String
        dt = dtp1.Value
        Dim actualDate = dt.Split(" ")(0).Replace("/", "-") ' Gets the  date selected in format yyyy/mm/dd

        Dim c As New SQLServerInterface
        Dim data As New DataTable
        Dim appendString As String = ""
        Dim source As New BindingSource
        data = c.RetreiveAllCompletedBookings() ' Retrieves Data from the database according to the selected date

        source.DataSource = data
        GridView1.DataSource = source

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nbf As New DeleteBookingForm
        nbf.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        Dim dt As String
        dt = dtp1.Value
        Dim actualDate = dt.Split(" ")(0).Replace("/", "-") ' Gets the  date selected in format yyyy/mm/dd

        Dim c As New SQLServerInterface
        Dim data As New DataTable
        Dim appendString As String = ""
        Dim source As New BindingSource

        data = c.RetreiveAllBookings() ' Retrieves Data from the database according to the selected date

        source.DataSource = data
        GridView1.DataSource = source
        'Checks if there is data present if not , it wil just display a  message


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim nbf As New EditForm
        nbf.Show()

    End Sub

End Class