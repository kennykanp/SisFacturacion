
Imports Capa_Datos
Imports Entidades
Public Class CategoriaBL
    Private oCapaDatos As New CategoriaDL

    Public Function AgregarCategoria(uCategoria As Categoria) As String
        Return oCapaDatos.Agregar(uCategoria)
    End Function

    Public Function ListarCategoria() As DataTable
        Return oCapaDatos.Listar
    End Function

    Public Function cargarCombo() As DataTable
        Return oCapaDatos.cargarCombo
    End Function

End Class
