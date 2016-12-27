Imports Capa_Negocio
Imports Entidades

Partial Class _Default
    Inherits System.Web.UI.Page
    Private oNegocio As New ClienteBL

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim Men As String
        Men = oNegocio.AgregarCliente(New Cliente(dniRuc.Text, telef.Text, nombreRazonSocial.Text, dir.Text, cboEstado.Text))
        Response.Write("<script labgyahe=javascript>alert('" & Men & "');</script>")
        Limpiar()
        verLista()

    End Sub

    Public Sub verLista()
        gvListar.DataSource = oNegocio.ListarEmpleados
        gvListar.DataBind()
    End Sub


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        id.Enabled = False
        btnActualizar.Enabled = False
        btnEliminar.Enabled = False
        btnGrabar.Enabled = False
        If Not Page.IsPostBack Then

        End If
        verLista()
    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
        btnActualizar.Enabled = True
        btnEliminar.Enabled = True
        btnGrabar.Enabled = True

    End Sub

    Public Sub Limpiar()
        id.Text = ""
        nombreRazonSocial.Text = ""
        dniRuc.Text = ""
        dir.Text = ""
        telef.Text = ""
        nombreRazonSocial.Focus()
        btnGrabar.Enabled = True
        btnActualizar.Enabled = False

    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        datos.Text = ""
        datos.Focus()
    End Sub

    Protected Sub gvListar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvListar.SelectedIndexChanged
        Try

            'Al Seleccionar los datos de nuestro GridView se pasaran a nuestras caja de texto y combobox'
            id.Text = gvListar.SelectedRow.Cells(1).Text
            nombreRazonSocial.Text = gvListar.SelectedRow.Cells(2).Text
            dniRuc.Text = gvListar.SelectedRow.Cells(3).Text
            dir.Text = gvListar.SelectedRow.Cells(4).Text
            telef.Text = gvListar.SelectedRow.Cells(5).Text

            id.Enabled = False
            btnGrabar.Enabled = False
            btnActualizar.Enabled = True
            
        Catch ex As Exception
            'Nos mostrara en un ventana el error'
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
