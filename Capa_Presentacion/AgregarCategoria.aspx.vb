Imports Capa_Negocio
Imports Entidades

Partial Class _Default
    Inherits System.Web.UI.Page
    Private oNegocio As New CategoriaBL

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Men As String
        Men = oNegocio.AgregarCategoria(New Categoria(txtNombre.Text.Trim, txtAbreviatura.Text.Trim, "1"))
        Response.Write("<script labgyahe=javascript>alert('" & Men & "');</script>")
    End Sub
End Class
