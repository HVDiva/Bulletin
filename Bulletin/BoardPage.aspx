<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BoardPage.aspx.cs" Inherits="Bulletin.BoardPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="boardPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="boardPlaceHolder2" runat="server">
    <table class="createlink" ><tr>
            
            <td>
                <asp:HyperLink ID="CreatePostLink" runat="server"><a href="MakePost.aspx">Create New Post</a></asp:HyperLink></td>
        </tr>
        </table>
</asp:Content>
