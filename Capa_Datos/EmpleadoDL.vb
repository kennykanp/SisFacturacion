Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class EmpleadoDL
    Private Cn As New BDConexion
    Public Function Agregar(oEmpleado As Empleado) As String
        Dim Cmd As New SqlCommand
        Dim R As String = "Registro Agregado"
        Try
            With Cmd
                .Connection = Cn.Conectar
                .CommandType = CommandType.StoredProcedure
                .CommandText = "AgregarUsuario"
                .Parameters.AddWithValue("@Nombre", oEmpleado.nombre)
                .Parameters.AddWithValue("@Apellidos", oEmpleado.apellido)
                .Parameters.AddWithValue("@tipoDocumento", oEmpleado.tipoDocumento)
                .Parameters.AddWithValue("@numDocumento", oEmpleado.numDocumento)
                .Parameters.AddWithValue("@sexo", oEmpleado.sexo)
                .Parameters.AddWithValue("@Direccion", oEmpleado.direccion)
                .Parameters.AddWithValue("@telefono", oEmpleado.telefono)
                .Parameters.AddWithValue("@email", oEmpleado.email)
                .Parameters.AddWithValue("@Login", oEmpleado.login)
                .Parameters.AddWithValue("@pass", oEmpleado.pass)
                .Parameters.AddWithValue("@tipoUsuario", oEmpleado.tipoUsuario)
                .Parameters.AddWithValue("@lEstado", oEmpleado.estado)
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
            Dim Da As New SqlDataAdapter("sp_ListarEmpleados", Cn.Conectar)
            Da.SelectCommand.CommandType = CommandType.StoredProcedure
            Da.Fill(Ds, "Empleado")
            Dt = Ds.Tables("Empleado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Dt
    End Function

    Public Function actualizaEmpleado(oEmpleado As Empleado)
        Dim cmd As New SqlCommand
        Dim r As String
        Try
            With cmd
                .Connection = Cn.Conectar
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_ActualizaEmpleado"
                .Parameters.AddWithValue("@Nombre", oEmpleado.nombre)
                .Parameters.AddWithValue("@Apellidos", oEmpleado.apellido)
                .Parameters.AddWithValue("@Direccion", oEmpleado.direccion)
                .Parameters.AddWithValue("@tipoUsuario", oEmpleado.tipoUsuario)
                .Parameters.AddWithValue("@tipoDocumento", oEmpleado.tipoDocumento)
                .Parameters.AddWithValue("@numDocumento", oEmpleado.numDocumento)
                .Parameters.AddWithValue("@telefono", oEmpleado.telefono)
                .Parameters.AddWithValue("@email", oEmpleado.email)
                .Parameters.AddWithValue("@sexo", oEmpleado.sexo)
                .Parameters.AddWithValue("@lEstado", oEmpleado.estado)
                Cn.abrir()
                .ExecuteNonQuery()
                r = "Empleado Actualizado"
                Cn.cerrar()
            End With
        Catch ex As Exception
            r = ex.Message

        End Try
        Return r
    End Function
End Class
