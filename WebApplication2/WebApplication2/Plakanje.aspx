<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Plakanje.aspx.cs" Inherits="WebApplication2.Plakanje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        Содржина на купувачката кошничка
    </div>
    <asp:ListBox ID="lbPay" runat="server"></asp:ListBox>
    <div>
       Вкупно: <asp:Label ID="totalSum" runat="server" Text=""></asp:Label> денари
    </div>
</asp:Content>
