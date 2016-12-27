<%@ Page Title="" Language="VB" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="false" CodeFile="AgregarCategoria.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 527px;
        }
        .auto-style6 {
            width: 98px;
        }
        .auto-style7 {
            width: 175px;
        }
        .auto-style8 {
            width: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td colspan="3" rowspan="2" style="font-family: 'Bernard MT Condensed'; font-size: 35px; background-color: #FFFFFF; text-align: center; color: #000000">AGREGAR CATEGORIAS</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="Label1" runat="server" Text="Nombre Cat"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="txtNombre" runat="server" Height="22px" Width="144px"></asp:TextBox>
            </td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="Label2" runat="server" Text="Abreviatura"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="txtAbreviatura" runat="server" Height="22px" Width="144px"></asp:TextBox>
            </td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">
                <asp:Button ID="btnAgregar" runat="server" Height="33px" Text="Agregar" Width="98px" />
            </td>
            <td class="auto-style7">
                <asp:Button ID="btnCancelar" runat="server" Height="33px" Text="Cancelar" Width="98px" />
            </td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

