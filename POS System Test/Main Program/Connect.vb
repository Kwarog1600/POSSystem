Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module Connect
    Public command As New MySqlCommand
    Public connection As New MySqlConnection
    Public reader As MySqlDataReader
    Public dt As DataTable
    Public da As MySqlDataAdapter
    Public query As String
    Public Sub Connect()
        Try
            connection.Close()
            connection = New MySqlConnection($"server=;database=;username=;password=")
            connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
