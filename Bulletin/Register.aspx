<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Bulletin.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="registerPlaceHolder" runat="server">
    <table class="table1">
        <tr>
            <th colspan="2"><h1>Register</h1></th>
        </tr>
        <tr>
            <td>Name:</td>
            <td>
                <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox><asp:Label class="label1" ID="NameLabel" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Username:</td>
            <td>
                <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox><asp:Label class="label1" ID="UsernameLabel" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Password:</td>
            <td>
                <asp:TextBox ID="Pass1TextBox" runat="server"></asp:TextBox><asp:Label class="label1" ID="Pass1Label" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Password again:</td>
            <td>
                <asp:TextBox ID="Pass2TextBox" runat="server"></asp:TextBox><asp:Label class="label1" ID="Pass2Label" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label class="label1" ID="MessageLabel" runat="server" Text=""></asp:Label></td>
                
            <td>
                <asp:Button class="centrebtn prettybutton" classID="registerbutton" runat="server" Text="Register" OnClick="RegisterButton_Click" /></td>
        </tr>
    </table>
</asp:Content>
