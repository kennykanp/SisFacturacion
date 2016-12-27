
Partial Class PaginaMaestra02
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblUsuario.Text = Request.QueryString("nom")
    End Sub
End Class

