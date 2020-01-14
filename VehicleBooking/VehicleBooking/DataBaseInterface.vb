Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class DataBaseInterface

    Public SQLCon As New SqlConnection With {.ConnectionString = "Data Source=DESKTOP-J92NKJD;Initial Catalog=PracticeDB;Integrated Security=True"}
    Public SQLCmd As SqlCommand


    Public Function CreateRecord(Name As String, Surname As String, Email As String, dt As DateTime, Gender As String) As Boolean
        Try

            SQLCon.Open()

            SQLCmd = New SqlCommand("Insert Into FormInformation Values ('" + Name + "','" + Surname + "','" + Email + "','" + dt + "');", SQLCon)

            SQLCmd.ExecuteNonQuery()


            Return True

        Catch ex As Exception
            MsgBox(ex.Message)

            Return False

        Finally

            SQLCon.Close()

        End Try
    End Function

    Public Function retreiveData(dt As String)

        Try
            Dim adapter As New SqlDataAdapter

            SQLCon.Open()

            SQLCmd = New SqlCommand("", SQLCon)
            Dim dataTable As New DataTable

            adapter.SelectCommand = SQLCmd
            adapter.Fill(dataTable)

        Catch ex As Exception

        Finally

            SQLCon.Close()

        End Try


    End Function


End Class
