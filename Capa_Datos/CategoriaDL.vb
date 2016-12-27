Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class CategoriaDL
    Private Cn As New BDConexion

    Public Function Agregar(oCategoria As Categoria) As String
        Dim Cmd As New SqlCommand
        Dim R As String = "Registro Agregado"
        Try
            With Cmd
                .Connection = Cn.Conectar
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_AgregarCategoria"
                .Parameters.AddWithValue("@Nombre", oCategoria.nombre)
                .Parameters.AddWithValue("@abreviatura", oCategoria.abreviatura)
                .Parameters.AddWithValue("@estado", oCategoria.estado)
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
            Dim Da As New SqlDataAdapter("sp_ListarCategoria", Cn.Conectar)
            Da.SelectCommand.CommandType = CommandType.StoredProcedure
            Da.Fill(Ds, "Categoria")
            Dt = Ds.Tables("Categoria")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Dt
    End Function

    Public Function cargarCombo() As DataTable
        Dim Dt As New DataTable
        Try
            Dim Ds As New DataSet
            Dim Da As New SqlDataAdapter("cargarCombo", Cn.Conectar)
            Da.SelectCommand.CommandType = CommandType.StoredProcedure
            Da.Fill(Ds, "Categoria")
            Dt = Ds.Tables("Categoria")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Dt
    End Function
End Class
