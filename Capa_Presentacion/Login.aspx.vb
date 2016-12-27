Imports Capa_Negocio
Imports Entidades

Partial Class Login
    Inherits System.Web.UI.Page

    Private oNegocio As New UsuarioBL

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub




    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If oNegocio.VerificarLogin(txtUsuario.Text.Trim, txtClave.Text.Trim) Then
            Response.Redirect("PaginaPrincipal.aspx?nom=" & txtUsuario.Text)

        Else
            Response.Write("<script labgyahe=javascript>alert('" & " Usuario y/o Contraseña Equivocada" & "');</script>")
        End If


        
    End Sub
End Class
