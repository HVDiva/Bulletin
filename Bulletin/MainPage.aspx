<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Bulletin.MainPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="mainPagePlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainPagePlaceHolder2" runat="server">
    <table class="createlink" ><tr>
            
            <td>
                <asp:HyperLink ID="CreateBoardLink" runat="server"><a href="MakeBoard.aspx">Create New Board</a></asp:HyperLink></td>
        </tr>
        </table>
</asp:Content>