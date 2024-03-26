<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="m-4">
            Име:<asp:TextBox ID="name" runat="server"></asp:TextBox> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Внесете име" ControlToValidate="name" style="color:red"></asp:RequiredFieldValidator>
        </div>
       
        <div class="m-4">
            Лозинка:<asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox> <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Внесете лозинка" ControlToValidate="password" style="color:red"></asp:RequiredFieldValidator>
        </div>

        <div class="m-4">
            е-адреса:<asp:TextBox ID="email" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Внесете е-адреса" ControlToValidate="email" style="color:red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Внесете правилна е-адреса" ControlToValidate="email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" style="color:red"></asp:RegularExpressionValidator>
        </div>
        <div class="m-4">
            <asp:Button ID="Btn1" runat="server" Text="Најавете се" OnClick="Najava_Click" />
        </div>

    </div>
</asp:Content>
