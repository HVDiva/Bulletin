<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Bulletin.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content11" ContentPlaceHolderID="errorPlaceHolder" runat="server">
<h1>Something unexpected happened!</h1>
    <asp:Label ID="errorLabel"
        runat="server" Text="Label"></asp:Label>
</asp:Content>
