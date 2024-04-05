<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="Movies_WebForm.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="text-end">
<asp:Label ID="show_username" runat="server" Text=""></asp:Label>
</div>
    <div class="text-center">
        <asp:Label ID="isEmptyCart" runat="server" Text="" ></asp:Label>
        <div>
            <asp:ListBox ID="lbItems" runat="server"></asp:ListBox>
        </div>
        <div>
            Total sum: <asp:Label ID="totalSum" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="removeItem" runat="server" Text="Remove Item" OnClick="removeItem_Click"/>
        </div>
        <div>
            <asp:Button ID="btnBuy" runat="server" Text="Order" OnClick="btnBuy_Click"/>
        </div>
    </div>
    <div>
        <asp:LinkButton ID="backCat" runat="server" OnClick="backCat_Click">Categories</asp:LinkButton>
    </div>
</asp:Content>
