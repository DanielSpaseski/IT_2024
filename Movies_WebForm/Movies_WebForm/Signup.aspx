<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="Movies_WebForm.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-center offset-2">
        <div>
            Username: <asp:TextBox ID="username" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Insert your username" ControlToValidate="username"></asp:RequiredFieldValidator>
        </div>
        <div>
            Email: <asp:TextBox ID="email" runat="server"></asp:TextBox><asp:RegularExpressionValidator ID="RegularExpressionValidator" runat="server" ErrorMessage="Insert valid email address" ControlToValidate="email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ></asp:RegularExpressionValidator>
        </div>
        <div>
            Password: <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="Insert your password" ControlToValidate="password"></asp:RequiredFieldValidator>
        </div>
        <div class="offset-1">
            Confirm Password: <asp:TextBox ID="confirmpassword" runat="server" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Insert your password" ControlToValidate="confirmpassword"></asp:RequiredFieldValidator><asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password must be same" ControlToCompare="password" ControlToValidate="confirmpassword"></asp:CompareValidator>
        </div>
    </div>
     <div class="text-center">
     <asp:Button ID="btnSignup" runat="server" Text="Sign up" OnClick="btnSignup_Click"/>
 </div>
</asp:Content>
