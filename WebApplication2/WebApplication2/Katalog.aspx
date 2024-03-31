<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Katalog.aspx.cs" Inherits="WebApplication2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="text-center">
    <asp:LinkButton ID="StrucnaLink" runat="server" Text="Стручна литература" OnClick="Strucna_Click"></asp:LinkButton><br />
    <asp:LinkButton ID="BeleLink" runat="server" Text="Белетристика" OnClick="Bele_Click"></asp:LinkButton><br />
    <asp:LinkButton ID="MagLink" runat="server" Text="Магазини" OnClick="Mag_Link"></asp:LinkButton>
    </div>
</asp:Content>
