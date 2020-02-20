<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bulletin.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="loginPlaceHolder" runat="server">
    <table class="table1">
        <tr>
            <th colspan="2"><h1>Login</h1></th>
        </tr>
        <tr>
            <td>Username:</td>
            <td>
                <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox><asp:Label class="label1" ID="UsernameLabel" runat="server" Text=" "></asp:Label></td>
        </tr>
        <tr>
            <td>Password:</td>
            <td>
                <asp:TextBox ID="PassTextBox" runat="server"></asp:TextBox><asp:Label class="label1" ID="PassLabel" runat="server" Text=" "></asp:Label></td>
        </tr>
        <tr>
            <td class="centrebtn">
                <asp:HyperLink ID="RegisterLink" runat="server"><a href="Register.aspx">Register</a></asp:HyperLink></td>
                
            <td>
                <asp:Button class="prettybutton" runat="server" Text="Login" OnClick="LoginButton_Click" /></td>
        </tr>
    </table>
</asp:Content>