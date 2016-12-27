<%@ Page Title="" Language="VB" MasterPageFile="~/PaginaMaestra02.master" AutoEventWireup="false" CodeFile="UniMedida.aspx.vb" Inherits="_Default" %>

<script runat="server">

    Protected Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub
</script>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1{
            margin:0px 0px 10px 35%;
        }
        .style5{
            margin:0px 0px 10px 10%;
        }
        .style13{
            margin:0px 0px 0px 1%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 style="text-align: center; font-family: 'Gill Sans MT Condensed'; font-size: 35px; background-color: #336699; color: #FFFFFF">Mantenimiento de Unidad de Medida-Productos (SQL SERVER)</h1>
<br />
    <table class="style1" align="center">
    <tr>
        <td class="style14">
            Codigo:</td>
        <td class="style3">
            <asp:TextBox ID="id" runat="server" MaxLength="10"></asp:TextBox>
        </td>
        
    </tr>
    <tr>
        <td class="style14">
            Nombre:</td>
        <td class="style3">
            <asp:TextBox ID="nomCategoria" runat="server" MaxLength="50"></asp:TextBox>
        </td>
        
    </tr>    
    <tr>
        <td class="style14">
            Estado:</td>
        <td class="style3">
            <asp:DropDownList ID="cboEstado" runat="server">
                <asp:ListItem>Activo</asp:ListItem>
                <asp:ListItem>Inactivo</asp:ListItem>
            </asp:DropDownList>

        </td>
    </tr>        
    <tr>
        <td class="style4" colspan="2">
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" />
            <asp:Button ID="btnGrabar" runat="server" Text="Grabar" />
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
            <asp:Button ID="btnLimpiar" runat="server" Text="←" />
            

        </td>
    </tr>
                
    <tr>
        <td class="style2" colspan="4">
            <asp:Label ID="Label1" runat="server" 
                style="font-size: medium; color: #0033CC; font-weight: 700"></asp:Label>
        </td>
    </tr>
</table>
<h1 style="text-align: center; font-family: 'Gill Sans MT Condensed'; font-size: 35px; background-color: #336699; color: #FFFFFF">Busqueda de Unidad de Medida</h1>
<br />

    <table align="center" class="style5">
        <tr>
            <td class="style11">
                Seleccione Opcion:</td>
            <td class="style12">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11">
                &nbsp;</td>
            <td class="style12">
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Codigo" 
                    GroupName="opcion" />
            </td>
            <td class="style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11">
                &nbsp;</td>
            <td class="style12">
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Nombre" 
                    GroupName="opcion" />
            </td>
            <td class="style10">
                &nbsp;</td>
        </tr>
        
        <tr>
            <td class="style11">
                Ingrese Datos:</td>
            <td class="style12">
                <asp:TextBox ID="datos" runat="server" Width="395px"></asp:TextBox>
            </td>
            <td class="style10">
                <asp:Button ID="Button4" runat="server" Text="Buscar" />
                <asp:Button ID="Button5" runat="server" Text="←" style="width: 27px" />
            </td>
        </tr>
        </table>
    <br />
    
    <table align="center" class="style13">
        <tr>
            <td>
    
    <asp:GridView ID="gvListar" runat="server" CellPadding="1" ForeColor="#333333" 
                    GridLines="None" Width="1300px" AllowPaging="True" PageSize="30">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                
                
            
            </td>
        </tr>
    </table>
</asp:Content>

