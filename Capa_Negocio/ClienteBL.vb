Imports Capa_Datos
Imports Entidades
Public Class ClienteBL
    Private oCapaDatos As New ClienteDL

    Public Function AgregarCliente(unCliente As Cliente) As String
        Return oCapaDatos.AgregarCliente(unCliente)
    End Function

    Public Function ListarEmpleados() As DataTable
        Return oCapaDatos.Listar
    End Function

End Class
