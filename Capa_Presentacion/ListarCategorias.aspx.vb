
Imports Capa_Negocio
Imports Entidades
Partial Class _Default
    Inherits System.Web.UI.Page
    Private oNegocio As New CategoriaBL

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        verLista()
    End Sub

    Sub verLista()
        gvListar.DataSource = oNegocio.ListarCategoria
        gvListar.DataBind()


    End Sub
End Class
