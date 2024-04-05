<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="Movies_WebForm.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-end">
<asp:Label ID="show_username" runat="server" Text=""></asp:Label>
        <div>
            <asp:Button ID="btnCart" runat="server" Text="Shopping cart" OnClick="btnCart_Click"/>
        </div>
</div>
<div class="text-center">
    <div>
        Choose your favorite category
    </div>
    <div>
        <asp:LinkButton ID="linkDrama" runat="server" OnClick="linkDrama_Click">Drama</asp:LinkButton>
    </div>
    <div>
        <asp:LinkButton ID="linkAction" runat="server" OnClick="linkAction_Click">Action</asp:LinkButton>
    </div>
    <div>
        <asp:LinkButton ID="linkComedy" runat="server" OnClick="linkComedy_Click">Comedy</asp:LinkButton>
    </div>
</div>
</asp:Content>
