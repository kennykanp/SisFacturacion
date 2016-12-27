<%@ Page Title="" Language="VB" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="false" CodeFile="ListarUsuarios.aspx.vb" Inherits="_Default" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style4 {
        width: 36%;
        height: 23px;
    }
    .auto-style15 {
    }
    .auto-style34 {
        width: 36%;
    }
    .auto-style36 {
        width: 14%;
    }
    .auto-style41 {
        width: 55%;
    }
    .auto-style42 {
        width: 3%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style34">&nbsp;</td>
        <td class="auto-style36">&nbsp;</td>
        <td class="auto-style42">&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style41">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style34">&nbsp;</td>
        <td colspan="3" rowspan="2" style="font-size: 35px; color: #000000; background-color: #FFFFFF; text-align: center; font-family: 'Bernard MT Condensed';">LISTADO EMPLEADOS</td>
        <td class="auto-style41">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style34">&nbsp;</td>
        <td class="auto-style41">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style34">&nbsp;</td>
        <td class="auto-style36">&nbsp;</td>
        <td class="auto-style42">&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style41">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4"></td>
        <td class="auto-style15" colspan="3" rowspan="3">
            <asp:GridView ID="gvListar" runat="server" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" Width="654px" CellSpacing="1" GridLines="None">
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
        <td class="auto-style41"></td>
    </tr>
    <tr>
        <td class="auto-style34">&nbsp;</td>
        <td class="auto-style41">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style34">&nbsp;</td>
        <td class="auto-style41">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style34">&nbsp;</td>
        <td class="auto-style36">&nbsp;</td>
        <td class="auto-style42">&nbsp;</td>
        <td>
            <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1">
                <series>
                    <asp:Series ChartType="Spline" Name="Series1">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PersonalConnectionString %>" SelectCommand="SELECT * FROM [Administrador]"></asp:SqlDataSource>
        </td>
        <td class="auto-style41">&nbsp;</td>
    </tr>
</table>
</asp:Content>

