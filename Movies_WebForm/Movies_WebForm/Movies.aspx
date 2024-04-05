<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Movies.aspx.cs" Inherits="Movies_WebForm.Movies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-end">
    <asp:Label ID="show_username" runat="server" Text=""></asp:Label>
    <div>
        <asp:Button ID="btnCart" runat="server" Text="Shopping cart" OnClick="btnCart_Click"/>
    </div>
</div>
<div class="text-center">
    <div>
        <asp:ListBox ID="lbMovies" runat="server" OnSelectedIndexChanged="lbMovies_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox><asp:ListBox ID="lbPrices" runat="server" OnSelectedIndexChanged="lbPrices_SelectedIndexChanged"></asp:ListBox>
    </div>
    <div>
        Selected: <asp:Label ID="totalSelected" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="btnAdd" runat="server" Text="Add to cart" OnClick="btnAdd_Click" />
    </div>
    <div class="text-start">
        <asp:LinkButton ID="linkCategories" runat="server" OnClick="linkCategories_Click">Categories</asp:LinkButton>
    </div>
</div>
</asp:Content>
