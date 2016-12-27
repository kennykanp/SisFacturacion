Imports Capa_Datos
Imports Entidades
Public Class ProductoBL
    Private oCapaDatos As New ProductoDL

    Public Function AgregarProducto(unProducto As Producto) As String
        Return oCapaDatos.Agregar(unProducto)
    End Function
    Public Function CargarCombo()
        Return oCapaDatos.CargarCombo
    End Function

    Public Function ListarProductos() As DataTable
        Return oCapaDatos.ListarProductos
    End Function
End Class
