Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class ClienteDL
    Private Cn As New BDConexion


    Public Function AgregarCliente(oCliente As Cliente) As String
        Dim Cmd As New SqlCommand
        Dim R As String = "Registro Agregado"
        Try
            With Cmd
                .Connection = Cn.Conectar
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_AgregarCliente"
                .Parameters.AddWithValue("@nombres", oCliente.Nombres)
                .Parameters.AddWithValue("@nroDoc", oCliente.nroDoc)
                .Parameters.AddWithValue("@direccion", oCliente.Direccion)
                .Parameters.AddWithValue("@telefono", oCliente.telefono)
                .Parameters.AddWithValue("@estado", oCliente.estado)
                Cn.abrir()
                .ExecuteNonQuery()
                Cn.cerrar()
            End With
        Catch Ex As Exception
            R = Ex.Message
        End Try
        Return R
    End Function

    Public Function Listar() As DataTable
        Dim Dt As New DataTable
        Try
            Dim Ds As New DataSet
            Dim Da As New SqlDataAdapter("sp_ListarClientes", Cn.Conectar)
            Da.SelectCommand.CommandType = CommandType.StoredProcedure
            Da.Fill(Ds, "Cliente")
            Dt = Ds.Tables("Cliente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Dt
    End Function

End Class
