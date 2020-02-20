<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="Bulletin.Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="accountPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="accountPlaceHolder2" runat="server">
 <%--   <asp:Button class="createbtn" ID="ChangePasswordButton" runat="server" Text="Change Password" OnClick="ChangePasswordButton_Click" />--%>
<table class="createlink" ><tr>
            
            <td>
                <asp:HyperLink ID="PasswordChangeLink" runat="server"><a href="ChangePassword.aspx">Change Password</a></asp:HyperLink></td>
        </tr>
        </table>
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="AccountPlaceHolder3" runat="server">
</asp:Content>
