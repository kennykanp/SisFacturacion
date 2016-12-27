Imports System.Data
Imports System.Data.SqlClient

Imports Capa_Negocio
Imports Entidades

Partial Class Default2
    Inherits System.Web.UI.Page
    Dim idCategoria, idUnidadMedida As Integer

    '--------------------------------------'
    Private oNegocio As New ProductoBL
    Private ocat As New CategoriaBL
    Private oUni As New UnidadMedidaBL


    Public Sub cargarCombo()
        cbocategoria.DataSource = ocat.cargarCombo
        cbocategoria.DataTextField = "Nombre"
        cbocategoria.DataValueField = "idCategoria"
        cbocategoria.DataBind()
    End Sub
    Public Sub cargarUniMedida()
        cbouniMedida.DataSource = oUni.cargarCombo
        cbouniMedida.DataTextField = "Nombre"
        cbouniMedida.DataValueField = "idUnidadMedida"
        cbouniMedida.DataBind()
    End Sub


    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub


    Public Sub Limpiar()
        id.Text = ""
        nom.Text = ""
        preCompra.Text = ""
        preVenta.Text = ""
        nom.Focus()

    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        id.Enabled = False
        If Not Page.IsPostBack Then
            cargarCombo()
            cargarUniMedida()

        End If
        verLista()
    End Sub


    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim Men As String
        Men = oNegocio.AgregarProducto(New Producto(cbocategoria.SelectedValue, cbouniMedida.SelectedValue, nom.Text.Trim, cboestado.Text, CDbl(preCompra.Text.Trim), CDbl(preVenta.Text.Trim)))
        Response.Write("<script labgyahe=javascript>alert('" & Men & "');</script>")
        Limpiar()
        verLista()
    End Sub

    Sub verLista()
        gvListar.DataSource = oNegocio.ListarProductos
        gvListar.DataBind()


    End Sub


    Protected Sub gvListar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvListar.SelectedIndexChanged
        Try

            'Al Seleccionar los datos de nuestro GridView se pasaran a nuestras caja de texto y combobox'
            id.Text = gvListar.SelectedRow.Cells(1).Text
            nom.Text = gvListar.SelectedRow.Cells(4).Text
            preCompra.Text = gvListar.SelectedRow.Cells(5).Text
            preVenta.Text = gvListar.SelectedRow.Cells(6).Text
            id.Enabled = False
            
        Catch ex As Exception
            'Nos mostrara en un ventana el error'
            MsgBox(ex.Message)
        End Try

    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        datos.Text = ""
        datos.Focus()
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class
