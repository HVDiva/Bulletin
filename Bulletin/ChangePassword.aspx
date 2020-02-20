<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Bulletin.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content17" ContentPlaceHolderID="changePasswordPlaceHolder" runat="server">
    <table class="table1">
        <tr>
            <th colspan="2"><h1>Change password</h1></th>
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
                <asp:Button class="centrebtn  prettybutton" ID="ChangePasswordButton" runat="server" Text="Change Password" OnClick="ChangePasswordButton_Click" /></td>
        </tr>
    </table>
</asp:Content>
