Imports Capa_Negocio
Imports Entidades

Partial Class Default2
    Inherits System.Web.UI.Page
    Private oNegocio As New EmpleadoBL

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        verLista()
        nom.Focus()
        id.Enabled = False

    End Sub

    Sub verLista()
        gvListar.DataSource = oNegocio.ListarEmpleados
        gvListar.DataBind()
    End Sub

    Protected Sub gvListar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvListar.SelectedIndexChanged
        Try

            'Al Seleccionar los datos de nuestro GridView se pasaran a nuestras caja de texto y combobox'
            id.Text = gvListar.SelectedRow.Cells(1).Text
            nom.Text = gvListar.SelectedRow.Cells(2).Text
            ape.Text = gvListar.SelectedRow.Cells(3).Text
            dir.Text = gvListar.SelectedRow.Cells(4).Text

            'dni.Text = gvListar.SelectedRow.Cells(5).Text
            car.Text = gvListar.SelectedRow.Cells(6).Text
            dni.Text = gvListar.SelectedRow.Cells(7).Text
            tel.Text = gvListar.SelectedRow.Cells(8).Text
            email.Text = gvListar.SelectedRow.Cells(9).Text
            est.Text = gvListar.SelectedRow.Cells(10).Text

            id.Enabled = False
            login.Enabled = False
            password.Enabled = False
        Catch ex As Exception
            'Nos mostrara en un ventana el error'
            MsgBox(ex.Message)
        End Try

    End Sub

    Protected Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Dim Men As String
        Men = oNegocio.AgregarEmpleado(New Empleado("0", nom.Text, ape.Text, tipoDocumento.Text, dni.Text, sex.Text, dir.Text, tel.Text, email.Text, login.Text, password.Text, car.Text, est.Text))
        Response.Write("<script labgyahe=javascript>alert('" & Men & "');</script>")

    End Sub



    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'Dim Men As String
        'Men = oNegocio.EditarEmpleado(New Empleado(id.Text, nom.Text, ape.Text, tipoDocumento.Text, dni.Text, sex.Text, dir.Text, tel.Text, email.Text, login.Text, password.Text, car.Text, est.Text))

        'MsgBox(Men)
        'gvListar.DataSource = oNegocio.ListarEmpleados
    End Sub

    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Sub Limpiar()
        id.Text = ""
        nom.Text = ""
        ape.Text = ""
        dir.Text = ""
        dni.Text = ""
        tel.Text = ""
        email.Text = ""
        login.Text = ""
        password.Text = ""
        nom.Focus()
    End Sub

    Public Sub Nuevo()
        id.Text = ""
        nom.Text = ""
        ape.Text = ""
        dir.Text = ""
        dni.Text = ""
        tel.Text = ""
        email.Text = ""
        login.Text = ""
        password.Text = ""
        id.Enabled = False
        login.Enabled = True
        password.Enabled = True
        nom.Focus()
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        datos.Text = ""
    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        datos.Text = ""
        datos.Focus()
    End Sub
End Class
