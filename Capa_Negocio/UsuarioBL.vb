Imports Capa_Datos
Imports Entidades
Public Class UsuarioBL
    Private oCapaDatos As New UsuarioDL
    Public Function VerificarLogin(Usuario As String, Pasword As String) As Boolean
        Return oCapaDatos.Login(Usuario, Pasword)
    End Function
End Class
