Imports System.Data
Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class BDConexion
    Private cn As New SqlConnection("server=DESARROLLADOR; database=DBFacturacion;integrated security=yes")

    Public Function Conectar() As SqlConnection
        Return cn
    End Function

    Public Sub abrir()
        cn.Open()
    End Sub

    Public Sub cerrar()
        cn.Close()
    End Sub
End Class
