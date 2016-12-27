Imports Capa_Negocio
Imports Entidades

Partial Class _Default
    Inherits System.Web.UI.Page
    Private oNegocio As New EmpleadoBL
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        verLista()
    End Sub

    Sub verLista()
        gvListar.DataSource = oNegocio.ListarEmpleados
        gvListar.DataBind()


    End Sub

    Protected Sub gvListar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvListar.SelectedIndexChanged

    End Sub
End Class
