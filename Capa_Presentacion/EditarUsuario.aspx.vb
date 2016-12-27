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

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Men As String
        Men = oNegocio.EditarEmpleado(New Empleado(txtNombre.Text, txtApellidos.Text, cboTipoDocumento.Text,
                                                    txtNumDocumento.Text, cboSexo.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text,
                                                    txtUsuario.Text, txtPassword.Text, cboTipoUsuario.Text, cboEstado.Text))
        MsgBox(Men)
        gvListar.DataSource = oNegocio.ListarEmpleados

    End Sub
End Class
