<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="Bulletin.UpdateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content12" ContentPlaceHolderID="updateUserPlaceHolder" runat="server">
    <table class="table1">
        <tr>
            <th colspan="2"><h1>Update User</h1></th>
        </tr>
        <tr>
            <td>Name:</td>
            <td>
                <asp:Label ID="NameLabel" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Username:</td>
            <td>
                <asp:Label ID="UsernameLabel" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>User Type</td>
            <td>
                <asp:RadioButtonList ID="RoleRadio" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RoleRadio_SelectedIndexChanged">
                    <asp:ListItem>ADMIN</asp:ListItem>
                    <asp:ListItem>USER</asp:ListItem>
                    <asp:ListItem>BLOCKED</asp:ListItem>
                </asp:RadioButtonList></td>
        </tr>
        <tr>
          
            <td colspan="2"><asp:Button Class="centrebtn" ID="UpdateUserButton" runat="server" Text="Save" OnClick="UpdateUserButton_Click" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button Class="centrebtn" ID="DeleteUserButton" runat="server" Text="Delete User" OnClick="DeleteUserButton_Click" /></td>
            
        </tr>
    </table>
</asp:Content>
