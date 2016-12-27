Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class ProductoDL
    Private Cn As New BDConexion

    Public Function Agregar(oProducto As Producto) As String
        Dim Cmd As New SqlCommand
        Dim R As String = "Registro Agregado"
        Try
            With Cmd
                .Connection = Cn.Conectar
                .CommandType = CommandType.StoredProcedure
                .CommandText = "insertar_producto"
                .Parameters.AddWithValue("@idcategoria", oProducto.idCategoria)
                .Parameters.AddWithValue("@idUnidadMedida", oProducto.idUnidadMedida)
                .Parameters.AddWithValue("@Nombre", oProducto.nombre)
                .Parameters.AddWithValue("@precio_compra", oProducto.precioCompra)
                .Parameters.AddWithValue("@precio_venta", oProducto.precioVentas)
                .Parameters.AddWithValue("@estado", oProducto.estado)
                
                Cn.abrir()
                .ExecuteNonQuery()
                Cn.cerrar()
            End With
        Catch Ex As Exception
            R = Ex.Message
        End Try
        Return R
    End Function

    Public Function CargarCombo() As DataTable
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

    Public Function ListarProductos() As DataTable
        Dim Dt As New DataTable
        Try
            Dim Ds As New DataSet
            Dim Da As New SqlDataAdapter("sp_ListarProducto", Cn.Conectar)
            Da.SelectCommand.CommandType = CommandType.StoredProcedure
            Da.Fill(Ds, "Productos")
            Dt = Ds.Tables("Productos")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Dt
    End Function

    
End Class
