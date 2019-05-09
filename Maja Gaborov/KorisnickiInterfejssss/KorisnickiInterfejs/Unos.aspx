<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Unos.aspx.cs" Inherits="KorisnickiInterfejs.Unos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 372px;
            text-align: right;
        }
        .style2
        {
            font-size: large;
        }
        .style3
        {
            width: 372px;
            text-align: right;
            height: 24px;
        }
        .style4
        {
            height: 24px;
        }
    .auto-style1 {
        width: 372px;
        text-align: right;
        height: 26px;
    }
    .auto-style2 {
        height: 26px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style2">
                <strong>UNOS</strong></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbID" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label2" runat="server" Text="ImeKandidata"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbImeKandidata" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>

        <tr>
            <td class="style1">
                <asp:Label ID="Label7" runat="server" Text="PrezimeKandidata"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbPrezimeKandidata" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
                      </tr>
        
        
            <td class="auto-style1">
                Mesto Kandidata</td>
            <td class="auto-style2">
                <asp:TextBox ID="txbMestoKandidata" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">
                </td>
        </tr>
        </tr>
        
        
            <td class="auto-style1">
                <asp:Label ID="Label9" runat="server" Text="AdresaKandidata"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="txbAdresaKandidata" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">
                </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label10" runat="server" Text="OblastTakmicenja"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlIOblastTakmicenja" runat="server" Height="24px" Width="220px">
                    <asp:ListItem>izaberite...</asp:ListItem>
                    <asp:ListItem>Pevanje</asp:ListItem>
                    <asp:ListItem>Sviranje</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
             <tr>
            <td class="auto-style1">
                BrojGodina<br />
                 </td>
            <td class="auto-style2">
                <asp:TextBox ID="txbBrojGodina" runat="server"></asp:TextBox>
                 </td>
            <td class="auto-style2">
                 </td>
        </tr>
                 <tr>
            <td class="style1">
                NazivSkole<br />
                     </td>
            <td>
                <asp:TextBox ID="txbNazivSkole" runat="server"></asp:TextBox>
                     </td>
            <td>
                &nbsp;</td>
        </tr>
          
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnSnimi" runat="server" Text="SNIMI" Width="95px" 
                    onclick="btnSnimi_Click" />
                <asp:Button ID="btnOdustani" runat="server" Text="ODUSTANI" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Label ID="lblStatus" runat="server" Text="status"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
