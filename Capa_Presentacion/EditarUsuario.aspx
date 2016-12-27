<%@ Page Title="" Language="VB" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="false" CodeFile="EditarUsuario.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style13 {
            width: 35%;
        }
        .auto-style19 {
            height: 50px;
            width: 97px;
        }
        .auto-style22 {
        }
        .auto-style63 {
            width: 8%;
        }
        .auto-style86 {
            width: 97px;
        }
        .auto-style89 {
            width: 35%;
            height: 30px;
        }
        .auto-style90 {
            width: 8%;
            height: 30px;
        }
        .auto-style91 {
            height: 30px;
            width: 13%;
        }
        .auto-style92 {
            width: 97px;
            height: 30px;
        }
        .auto-style93 {
            width: 44%;
            height: 30px;
        }
        .auto-style94 {
            width: 35%;
            height: 24px;
        }
        .auto-style95 {
            width: 8%;
            height: 24px;
        }
        .auto-style96 {
            height: 24px;
            width: 13%;
        }
        .auto-style97 {
            width: 97px;
            height: 24px;
        }
        .auto-style98 {
            width: 44%;
            height: 24px;
        }
        .auto-style99 {
            width: 13%;
        }
        .auto-style102 {
            width: 44%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style13" colspan="2">&nbsp;</td>
            <td class="auto-style63" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">&nbsp;</td>
            <td class="auto-style99">&nbsp;</td>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style102">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="2">&nbsp;</td>
        <td colspan="3" rowspan="2" style="color: #000000; text-align: center; background-color: #FFFFFF; font-size: 35px; font-family: 'Bernard MT Condensed';">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; EDITAR EMPLEADOS</td>
            <td class="auto-style102">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="2">&nbsp;</td>
            <td class="auto-style102">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="2">&nbsp;</td>
            <td class="auto-style63">&nbsp;</td>
            <td class="auto-style99">&nbsp;</td>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style102">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style94" colspan="2"></td>
        <td class="auto-style95" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">
            <asp:Label ID="Label12" runat="server" Text="ID Empleado"></asp:Label>
        </td>
        <td class="auto-style96">
            <asp:TextBox ID="txtCodigo" runat="server" Width="141px"></asp:TextBox>
        </td>
        <td class="auto-style97" style="color: #000000; font-size: 20px; font-family: 'Bernard MT Condensed'">
        </td>
        <td class="auto-style98">
        </td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="2">&nbsp;</td>
        <td class="auto-style63" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        </td>
        <td class="auto-style99">
            <asp:TextBox ID="txtNombre" runat="server" Width="143px"></asp:TextBox>
        </td>
        <td class="auto-style86" style="color: #000000; font-size: 20px; font-family: 'Bernard MT Condensed'">
            <asp:Label ID="Label7" runat="server" Text="Usuario"></asp:Label>
            </td>
        <td class="auto-style102">
            <asp:TextBox ID="txtUsuario" runat="server" style="margin-left: 0px"></asp:TextBox>
        </td>
        </tr>
        <tr>
            <td class="auto-style89" colspan="2"></td>
            <td class="auto-style90" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">
            <asp:Label ID="Label2" runat="server" Text="Apellidos"></asp:Label>
            </td>
            <td class="auto-style91">
            <asp:TextBox ID="txtApellidos" runat="server" Width="143px"></asp:TextBox>
            </td>
        <td class="auto-style92" style="color: #000000; font-size: 20px; font-family: 'Bernard MT Condensed'">Password</td>
            <td class="auto-style93">
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="2">&nbsp;</td>
            <td class="auto-style63" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">
                <asp:Label ID="Label8" runat="server" Text="Tipo Documento"></asp:Label>
            </td>
            <td class="auto-style99">
            <asp:DropDownList ID="cboTipoDocumento" runat="server">
                <asp:ListItem>DNI</asp:ListItem>
                <asp:ListItem>Pasaporte</asp:ListItem>
                <asp:ListItem>Carnet de Extranjeria</asp:ListItem>
            </asp:DropDownList>
            </td>
        <td class="auto-style19" style="color: #000000; font-size: 20px; font-family: 'Bernard MT Condensed'">Tipo Usuario</td>
            <td class="auto-style102">
            <asp:DropDownList ID="cboTipoUsuario" runat="server">
                <asp:ListItem>Administrador</asp:ListItem>
                <asp:ListItem>Vendedor</asp:ListItem>
            </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="2">&nbsp;</td>
            <td class="auto-style63" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">
                <asp:Label ID="Label9" runat="server" Text="Numero Documento"></asp:Label>
            </td>
            <td class="auto-style99">
            <asp:TextBox ID="txtNumDocumento" runat="server" Width="143px"></asp:TextBox>
            </td>
        <td class="auto-style86" style="color: #000000; font-size: 20px; font-family: 'Bernard MT Condensed'">Estado</td>
            <td class="auto-style102">
            <asp:DropDownList ID="cboEstado" runat="server">
                <asp:ListItem>Activo</asp:ListItem>
                <asp:ListItem>Inactivo</asp:ListItem>
            </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="2" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">&nbsp;</td>
            <td class="auto-style63" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">
                <asp:Label ID="Label10" runat="server" Text="Sexo"></asp:Label>
            </td>
            <td class="auto-style99" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">
            <asp:DropDownList ID="cboSexo" runat="server">
                <asp:ListItem>Hombre</asp:ListItem>
                <asp:ListItem>Mujer</asp:ListItem>
            </asp:DropDownList>
            </td>
            <td class="auto-style86" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">
            <asp:Button ID="btnAgregar" runat="server" Text="EDITAR" Width="70px" Height="30px" />
            </td>
            <td class="auto-style102" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">
            <asp:Button ID="btnCancelar" runat="server" Text="CANCELAR" Width="70px" Height="30px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="2">&nbsp;</td>
        <td class="auto-style63" style="font-size: 20px; font-family: 'Bernard MT Condensed'; color: #000000">
            <asp:Label ID="Label11" runat="server" Text="Direccion"></asp:Label>
            </td>
            <td class="auto-style99">
            <asp:TextBox ID="txtDireccion" runat="server" Width="143px"></asp:TextBox>
            </td>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style102">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="2">&nbsp;</td>
        <td class="auto-style63" style="font-size: 20px; font-family: 'Bernard MT Condensed'; color: #000000">Telefono</td>
            <td class="auto-style99">
            <asp:TextBox ID="txtTelefono" runat="server" Width="143px"></asp:TextBox>
            </td>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style102">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="2">&nbsp;</td>
        <td class="auto-style63" style="font-size: 20px; font-family: 'Bernard MT Condensed'; color: #000000">Email</td>
            <td class="auto-style99">
            <asp:TextBox ID="txtEmail" runat="server" Width="143px"></asp:TextBox>
            </td>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style102">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style63">&nbsp;</td>
            <td class="auto-style22" colspan="5" rowspan="7">
                <asp:GridView ID="gvListar" runat="server" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" style="margin-left: 94px" Width="919px">
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#594B9C" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#33276A" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style63">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style63">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style63">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style63">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style63">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style63">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

