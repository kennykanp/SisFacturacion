Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class UnidadMedidaDL
    Private Cn As New BDConexion

    Public Function Agregar(oUnidadMedida As UnidadMedida) As String
        Dim Cmd As New SqlCommand
        Dim R As String = "Registro Agregado"
        Try
            With Cmd
                .Connection = Cn.Conectar
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_InsertarUnidaMedida"
                .Parameters.AddWithValue("@Nombre", oUnidadMedida.nombre)
                .Parameters.AddWithValue("@estado", oUnidadMedida.estado)
                Cn.abrir()
                .ExecuteNonQuery()
                Cn.cerrar()
            End With
        Catch Ex As Exception
            R = Ex.Message
        End Try
        Return R
    End Function

    Public Function CargarComboUnidadMedida() As DataTable
        Dim Dt As New DataTable
        Try
            Dim Ds As New DataSet
            Dim Da As New SqlDataAdapter("sp_listarUnidadMedida", Cn.Conectar)
            Da.SelectCommand.CommandType = CommandType.StoredProcedure
            Da.Fill(Ds, "UnidadMedida")
            Dt = Ds.Tables("UnidadMedida")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Dt
    End Function
End Class
