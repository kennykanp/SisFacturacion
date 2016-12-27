Imports Capa_Datos
Imports Entidades
Public Class EmpleadoBL
    Private oCapaDatos As New EmpleadoDL

    Public Function AgregarEmpleado(unEmpleado As Empleado) As String
        Return oCapaDatos.Agregar(unEmpleado)
    End Function
    Public Function EditarEmpleado(unEmpleado As Empleado) As String
        Return oCapaDatos.actualizaEmpleado(unEmpleado)
    End Function
    Public Function ListarEmpleados() As DataTable
        Return oCapaDatos.Listar
    End Function

    
End Class
