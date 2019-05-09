<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeteTabelarni.aspx.cs" Inherits="KorisnickiInterfejs.DeteTabelarni" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 215px;
        }
        .style2
        {
            width: 534px;
        }
        .style3
        {
            width: 534px;
            font-weight: bold;
        }
        .style4
        {
            width: 215px;
            font-weight: bold;
        }
        .style5
        {
            font-size: large;
        }
        .style6
        {
            width: 215px;
            height: 21px;
        }
        .style7
        {
            width: 534px;
            height: 21px;
        }
        .style8
        {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                <span class="style5">
            </td>
            <td class="style3">
                TABELARNI PRIKAZ PODATAKA O DECI</span></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                </td>
            <td class="style7">
                </td>
            <td class="style8">
                </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" Text="Prezime ="></asp:Label>
                <asp:TextBox ID="txbFilterPrezime" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                <asp:Button ID="btnFiltriraj" runat="server" Text="FILTRIRAJ" Width="116px" />
                <asp:Button ID="btnPrikaziSve" runat="server" Text="PRIKAZI SVE" 
                    onclick="btnPrikaziSve_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                <asp:GridView ID="gvSpisakDece" runat="server" Height="197px" Width="527px">
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
