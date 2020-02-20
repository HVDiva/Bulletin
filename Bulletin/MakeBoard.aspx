<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MakeBoard.aspx.cs" Inherits="Bulletin.MakeBoard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content15" ContentPlaceHolderID="makeBoardPlaceHolder" runat="server">
    <table class="table1">
        <tr>
            <th colspan="2"><h1>Create a new board</h1></th>
        </tr>
        <tr>
            <td>Name of board:</td>
            <td>
                <asp:TextBox ID="BoardNameTextBox" runat="server"></asp:TextBox><asp:Label class="label1" ID="BoardNameLabel" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label class="label1" ID="MessageLabel" runat="server" Text=""></asp:Label></td>
                
            <td>
                <asp:Button class="centrebtn prettybutton" ID="CreateBoardButton" runat="server" Text="Create Board" OnClick="CreateBoardButton_Click" /></td>
        </tr>
    </table>
</asp:Content>
