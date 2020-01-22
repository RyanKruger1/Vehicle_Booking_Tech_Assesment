Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQLServerInterface
    'Public SQLCon As New SqlConnection With {.ConnectionString = "Server=localhost;Database=PracticeDB;Trusted_Connection=True;"}

    Public SQLCon As New SqlConnection With {.ConnectionString = "Server=tcp:ryanserver.database.windows.net,1433;Initial Catalog=Ryan_DB;Persist Security Info=False;User ID=goku;Password=Kru@2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"}
    Public SQLCmd As SqlCommand


    Public Function InsertBooking(name As String, car As String, dte As String, notes As String) As Boolean
        Try
            Dim dataTable As New DataTable
            Dim adapter As New SqlDataAdapter
            SQLCon.Open()

            SQLCmd = New SqlCommand("Select * FROM VehicleBookings ", SQLCon)

            adapter.SelectCommand = SQLCmd
            adapter.Fill(dataTable)
            Dim val As Integer
            If dataTable.Rows.Count < 1 Then

                val = 1

            Else


                val = dataTable.Rows(dataTable.Rows.Count - 1)(0) + 1
            End If
            Dim query As String

            query = "Insert Into VehicleBookings Values(" + val.ToString + ",'" + name + "','" + car + "','" + dte + "','" + notes + "');"
            SQLCmd = New SqlCommand(query, SQLCon)

            Dim changedRows As Integer = SQLCmd.ExecuteNonQuery()

            If changedRows = 0 Then
                Return False
            End If

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

            SQLCmd = New SqlCommand("Delete from VehicleBookings Where [Client] ='" + name + "' And [Vehicle_Model] = '" + car + "' And [Date_of_Booking] = '" + dte + "' ", SQLCon)

            Dim changedRows As Integer = SQLCmd.ExecuteNonQuery()

            If changedRows = 0 Then
                Return False
            End If



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

    Public Function DeleteBookingWithID(id As String, Name As String) As Boolean
        Dim dataTable As New DataTable

        Try
            Dim adapter As New SqlDataAdapter

            SQLCon.Open()

            Dim today As String = DateTime.Now.ToString("yyyy-MM-dd")

            SQLCmd = New SqlCommand("Delete From VehicleBookings where id =" + id + " And Client = '" + Name + "'", SQLCon)

            Dim changedRows As Integer = SQLCmd.ExecuteNonQuery()

            If changedRows = 0 Then

                Return False

            End If

            adapter.SelectCommand = SQLCmd
            adapter.Fill(dataTable)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            SQLCon.Close()

        End Try
        Return True

    End Function

End Class







