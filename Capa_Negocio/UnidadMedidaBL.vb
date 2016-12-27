
Imports Capa_Datos
Imports Entidades
Public Class UnidadMedidaBL
    Private oCapaDatos As New UnidadMedidaDL

    Public Function AgregarUnidadMedida(uUnidadMedida As UnidadMedida) As String
        Return oCapaDatos.Agregar(uUnidadMedida)
    End Function
    Public Function cargarCombo() As DataTable
        Return oCapaDatos.CargarComboUnidadMedida
    End Function

    Public Function ListarUnidadMedida() As DataTable
        Return oCapaDatos.CargarComboUnidadMedida
    End Function
End Class
