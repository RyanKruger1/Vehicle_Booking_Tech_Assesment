Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Class1

    Public SQLCon As New SqlConnection With {.ConnectionString = "Data Source=DESKTOP-J92NKJD;Initial Catalog=PracticeDB;Integrated Security=True"}
    Public SQLCmd As SqlCommand


    Public Function InsertBooking(name As String, car As String, dte As String, notes As String) As Boolean
        Try

            SQLCon.Open()

            SQLCmd = New SqlCommand("Insert Into VehicleBookings Values ('" + name + "','" + car + "','" + dte + "','" + notes + "');", SQLCon)

            SQLCmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)

            Return False

        Finally

            SQLCon.Close()

        End Try
    End Function

    Public Function RetreiveRecordsOfACertainDate(dt As String) As DataTable
        Dim dataTable As New DataTable

        Try
            Dim adapter As New SqlDataAdapter

            SQLCon.Open()


            SQLCmd = New SqlCommand("Select * FROM VehicleBookings where Date_of_Booking = '" + dt + "'", SQLCon)

            adapter.SelectCommand = SQLCmd
            adapter.Fill(dataTable)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            SQLCon.Close()

        End Try
        Return dataTable

    End Function
    Public Function RetreiveAllCompletedBookings() As DataTable
        Dim dataTable As New DataTable

        Try
            Dim adapter As New SqlDataAdapter

            SQLCon.Open()


            Dim today As String = DateTime.Now.ToString("yyyy-MM-dd")
            SQLCmd = New SqlCommand("Select * FROM VehicleBookings where Date_of_Booking < '" + today + "' Order By Date_of_Booking Desc", SQLCon)


            adapter.SelectCommand = SQLCmd
            adapter.Fill(dataTable)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            SQLCon.Close()

        End Try
        Return dataTable

    End Function

    Public Function RetreiveAllDueBookings() As DataTable
        Dim dataTable As New DataTable

        Try
            Dim adapter As New SqlDataAdapter

            SQLCon.Open()

            Dim today As String = DateTime.Now.ToString("yyyy-MM-dd")
            SQLCmd = New SqlCommand("Select * FROM VehicleBookings where Date_of_Booking > '" + today + "' Order By Date_of_Booking", SQLCon)

            adapter.SelectCommand = SQLCmd
            adapter.Fill(dataTable)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            SQLCon.Close()

        End Try
        Return dataTable

    End Function

    Public Function DeleteBooking(name As String, car As String, dte As String) As Boolean
        Try

            SQLCon.Open()

            SQLCmd = New SqlCommand("Delete from VehicleBookings Where Client ='" + name + "' And Vehicle_Model = '" + car + "' And Date_of_Booking = '" + dte + "' ", SQLCon)

            SQLCmd.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)

            Return False

        Finally

            SQLCon.Close()

        End Try
    End Function

    Public Function RetreiveAllBookings() As DataTable
        Dim dataTable As New DataTable

        Try
            Dim adapter As New SqlDataAdapter

            SQLCon.Open()


            Dim today As String = DateTime.Now.ToString("yyyy-MM-dd")
            SQLCmd = New SqlCommand("Select * FROM VehicleBookings", SQLCon)


            adapter.SelectCommand = SQLCmd
            adapter.Fill(dataTable)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            SQLCon.Close()

        End Try
        Return dataTable

    End Function


End Class







