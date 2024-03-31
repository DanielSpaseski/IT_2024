<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Proizvodi.aspx.cs" Inherits="WebApplication2.Proizvodi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="category" runat="server" Text="(none)" Font-Size="X-Large" ></asp:Label>
    </div>
    <div>
            <strong>Наслов</strong><strong style="margin-left:225px">Цена</strong>
    </div>
    <div>
            <asp:ListBox ID="lbTitles" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lbTitles_SelectedIndexChanged"></asp:ListBox>
            <asp:ListBox ID="lbPrices" runat="server"></asp:ListBox>
    </div>
    <div>
        <asp:LinkButton ID="btnBack" runat="server" OnClick="Back_Click">Каталог</asp:LinkButton>
        <asp:Button ID="btnAddItem" runat="server" Text="Додади во кошничка" OnClick="AddItem_Click" />
        <asp:Label ID="total" runat="server" Text="0"></asp:Label>
    </div>
    <div>
        <asp:ListBox ID="lbShoppingCart" runat="server"></asp:ListBox><br />
        <asp:Button ID="btnBuy" runat="server" Text="Купи" OnClick="Buy_Click"/>
    </div>
  
</asp:Content>
