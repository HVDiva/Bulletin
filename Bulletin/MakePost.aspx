<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MakePost.aspx.cs" Inherits="Bulletin.MakePost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content16" ContentPlaceHolderID="makePostPlaceHolder" runat="server">
    <table class="table1">
        <tr>
            <th colspan="2"><h1>Create a new post</h1></th>
        </tr>
        <tr>
            <td>Your new post:</td>
            <td>
                <textarea id="PostTextArea" runat="server" cols="20" rows="4"></textarea>
                <%--<asp:TextBox ID="PostTextBox" runat="server"></asp:TextBox>--%>
                <asp:Label class="label1" ID="PostTextLabel" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label class="label1" ID="MessageLabel" runat="server" Text=""></asp:Label></td>
                
            <td>
                <asp:Button class="centrebtn prettybutton" ID="CreatePostButton" runat="server" Text="Create Post" OnClick="CreatePostButton_Click" /></td>
        </tr>
    </table>
</asp:Content>
