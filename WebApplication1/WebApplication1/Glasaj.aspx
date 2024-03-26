<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="WebApplication1.Glasaj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div style="width:300px">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/logo_10.png" Width="300px" />
        </div>
        <div>
        <asp:Label ID="lblProf" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:ListBox ID="lbPredmeti" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lbPredmeti_SelectedIndexChanged"></asp:ListBox>
            <asp:ListBox ID="lbKrediti" runat="server" OnSelectedIndexChanged="lbKrediti_SelectedIndexChanged"></asp:ListBox>
        </div>
        <div>
            <asp:Button ID="btn_vote" runat="server" Text="Гласајте" OnClick="Glasajte_Click" />
        </div>
        <div>
            Предмет:<br />
            <asp:TextBox ID="newPredmet" runat="server"></asp:TextBox>
        </div>
        <div>
            Кредити:<br />
            <asp:TextBox ID="newKrediti" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnAdd" runat="server" Text="Додади" OnClick="AddSubject_Click" />
        </div>
        <div>
            <asp:Button ID="btnRemove" runat="server" Text="Избриши" OnClick="RemoveSubject_Click"/>
        </div>
    </div>
</asp:Content>
