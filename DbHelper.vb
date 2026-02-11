Imports System.Data.SqlClient

Module DbHelper

    Public Function TestarConexao(connString As String) As Boolean
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Return True
            End Using
        Catch
            Return False
        End Try
    End Function

End Module

