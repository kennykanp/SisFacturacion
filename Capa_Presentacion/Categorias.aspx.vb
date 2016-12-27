Imports Capa_Negocio
Imports Entidades
Partial Class Default3
    Inherits System.Web.UI.Page
    Private oNegocio As New CategoriaBL

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        id.Enabled = False
        If Not Page.IsPostBack Then

        End If
        verLista()
    End Sub

    Public Sub verLista()
        gvListar.DataSource = oNegocio.ListarCategoria
        gvListar.DataBind()
    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim Men As String
        Men = oNegocio.AgregarCategoria(New Categoria(0, nomCategoria.Text, abreviatura.Text, cboEstado.Text))
        Response.Write("<script labgyahe=javascript>alert('" & Men & "');</script>")
        Limpiar()
        verLista()
    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()

    End Sub

    Public Sub Limpiar()
        id.Text = ""
        nomCategoria.Text = ""
        abreviatura.Text = ""
        nomCategoria.Focus()
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        datos.Text = ""
        datos.Focus()
    End Sub
End Class
