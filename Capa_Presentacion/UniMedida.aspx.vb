Imports Capa_Negocio
Imports Entidades
Partial Class _Default
    Inherits System.Web.UI.Page
    Private oNegocio As New UnidadMedidaBL

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim Men As String
        Men = oNegocio.AgregarUnidadMedida(New UnidadMedida(0, nomCategoria.Text, cboEstado.Text))
        Response.Write("<script labgyahe=javascript>alert('" & Men & "');</script>")
        Limpiar()
        verLista()
        
    End Sub

    Public Sub verLista()
        gvListar.DataSource = oNegocio.ListarUnidadMedida
        gvListar.DataBind()
    End Sub


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        id.Enabled = False
        If Not Page.IsPostBack Then

        End If
        verLista()
    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Public Sub Limpiar()
        id.Text = ""
        nomCategoria.Text = ""
        nomCategoria.Focus()
        id.Enabled = False
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        datos.Text = ""
        datos.Focus()
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Protected Sub gvListar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvListar.SelectedIndexChanged
        Try

            'Al Seleccionar los datos de nuestro GridView se pasaran a nuestras caja de texto y combobox'
            id.Text = gvListar.SelectedRow.Cells(1).Text
            nomCategoria.Text = gvListar.SelectedRow.Cells(2).Text
            cboEstado.Text = gvListar.SelectedRow.Cells(3).Text

            
        Catch ex As Exception
            'Nos mostrara en un ventana el error'
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
