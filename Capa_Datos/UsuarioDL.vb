Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class UsuarioDL
    Private Cn As New BDConexion

    Public Function Login(Usuario As String, Pasword As String) As Boolean
        Dim Valor As Boolean = False
        Dim Cmd As New SqlCommand
        Dim Dr As SqlDataReader
        Try
            With Cmd
                .Connection = Cn.Conectar
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_Login"

                .Parameters.AddWithValue("@login", Usuario)
                .Parameters.AddWithValue("@password", Pasword)
                Cn.abrir()
                Dr = .ExecuteReader
                If Dr.Read = True Then
                    Valor = True
                End If
                Cn.cerrar()
            End With
        Catch Ex As Exception
            MsgBox(Ex.Message)
            Valor = False
        End Try
        Return Valor
    End Function
End Class
