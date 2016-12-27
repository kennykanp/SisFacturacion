<%@ Page Title="" Language="VB" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="false" CodeFile="AgregarUsuarios.aspx.vb" Inherits="_Default" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table class="auto-style1">
    <tr>
        <td class="auto-style30" colspan="5">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style50">&nbsp;</td>
        <td colspan="3" rowspan="2" style="color: #000000; text-align: center; background-color: #FFFFFF; font-size: 35px; font-family: 'Bernard MT Condensed';">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; REGISTRO DE EMPLEADOS</td>
        <td class="auto-style60">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style50">&nbsp;</td>
        <td class="auto-style60">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style18" colspan="5">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style31"></td>
        <td class="auto-style43" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        </td>
        <td class="auto-style51">
            <asp:TextBox ID="txtNombre" runat="server" Width="143px"></asp:TextBox>
        </td>
        <td class="auto-style27" style="color: #000000; font-size: 20px; font-family: 'Bernard MT Condensed'">
            <asp:Label ID="Label7" runat="server" Text="Usuario"></asp:Label>
        </td>
        <td class="auto-style17">
            <asp:TextBox ID="txtUsuario" runat="server" style="margin-left: 0px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style50">&nbsp;</td>
        <td class="auto-style42" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">
            <asp:Label ID="Label2" runat="server" Text="Apellidos"></asp:Label>
        </td>
        <td class="auto-style52">
            <asp:TextBox ID="txtApellidos" runat="server" Width="143px"></asp:TextBox>
        </td>
        <td class="auto-style61" style="color: #000000; font-size: 20px; font-family: 'Bernard MT Condensed'">Password</td>
        <td class="auto-style60">
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style36"></td>
        <td class="auto-style44" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">
            <asp:Label ID="Label3" runat="server" Text="Tipo de Documento"></asp:Label>
        </td>
        <td class="auto-style53">
            <asp:DropDownList ID="cboTipoDocumento" runat="server">
                <asp:ListItem>DNI</asp:ListItem>
                <asp:ListItem>Pasaporte</asp:ListItem>
                <asp:ListItem>Carnet de Extranjeria</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="auto-style38" style="color: #000000; font-size: 20px; font-family: 'Bernard MT Condensed'">Tipo Usuario</td>
        <td class="auto-style39">
            <asp:DropDownList ID="cboTipoUsuario" runat="server">
                <asp:ListItem>Administrador</asp:ListItem>
                <asp:ListItem>Vendedor</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style50">&nbsp;</td>
        <td class="auto-style42" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">
            <asp:Label ID="Label4" runat="server" Text="Numero Documento"></asp:Label>
        </td>
        <td class="auto-style52">
            <asp:TextBox ID="txtNumDocumento" runat="server" Width="143px"></asp:TextBox>
        </td>
        <td class="auto-style61" style="color: #000000; font-size: 20px; font-family: 'Bernard MT Condensed'">Estado</td>
        <td class="auto-style60">
            <asp:DropDownList ID="cboEstado" runat="server">
                <asp:ListItem>Activo</asp:ListItem>
                <asp:ListItem>Inactivo</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style50">&nbsp;</td>
        <td class="auto-style42" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">
            <asp:Label ID="Label5" runat="server" Text="Sexo"></asp:Label>
        </td>
        <td class="auto-style52">
            <asp:DropDownList ID="cboSexo" runat="server">
                <asp:ListItem>Hombre</asp:ListItem>
                <asp:ListItem>Mujer</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="auto-style61" colspan="2">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" Width="70px" Height="30px" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="70px" Height="30px" />
            </td>
    </tr>
    <tr>
        <td class="auto-style50">&nbsp;</td>
        <td class="auto-style42" style="font-family: 'Bernard MT Condensed'; font-size: 20px; color: #000000">
            <asp:Label ID="Label6" runat="server" Text="Direccion"></asp:Label>
        </td>
        <td class="auto-style52">
            <asp:TextBox ID="txtDireccion" runat="server" Width="143px"></asp:TextBox>
        </td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style60">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style50">&nbsp;</td>
        <td class="auto-style42" style="font-size: 20px; font-family: 'Bernard MT Condensed'; color: #000000">Telefono</td>
        <td class="auto-style52">
            <asp:TextBox ID="txtTelefono" runat="server" Width="143px"></asp:TextBox>
        </td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style60">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style50">&nbsp;</td>
        <td class="auto-style42" style="font-size: 20px; font-family: 'Bernard MT Condensed'; color: #000000">Email</td>
        <td class="auto-style52">
            <asp:TextBox ID="txtEmail" runat="server" Width="143px"></asp:TextBox>
        </td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style60">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style50">&nbsp;</td>
        <td class="auto-style42">
            &nbsp;</td>
        <td class="auto-style52">&nbsp;</td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style60">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style30" colspan="5">&nbsp;</td>
    </tr>
    </table>
    
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style17 {
        height: 24px;
    }
    .auto-style18 {
    }
    .auto-style27 {
        height: 24px;
        width: 97px;
    }
    .auto-style30 {
        }
    .auto-style31 {
        width: 31%;
        height: 24px;
    }
    .auto-style36 {
        width: 31%;
        height: 27px;
    }
    .auto-style38 {
        width: 97px;
        height: 27px;
    }
    .auto-style39 {
        width: 36%;
        height: 27px;
    }
        .auto-style42 {
            width: 13%;
        }
        .auto-style43 {
            width: 13%;
            height: 24px;
        }
        .auto-style44 {
            width: 13%;
            height: 27px;
        }
        .auto-style50 {
            width: 31%;
        }
        .auto-style51 {
            width: 12%;
            height: 24px;
        }
        .auto-style52 {
            width: 12%;
        }
        .auto-style53 {
            width: 12%;
            height: 27px;
        }
        .auto-style60 {
            width: 36%;
        }
        .auto-style61 {
        }
    </style>
 </asp:Content>
