<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="SummitCommunity.Admin.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Hello, admin!</h1>

    <asp:Label ID="LabelAddCategory" runat="server" Text="Add Category:"></asp:Label>
    <asp:TextBox ID="TextBoxAddCategory" runat="server"></asp:TextBox>
    <asp:FileUpload ID="FileControl" runat="server" />
    <asp:Button ID="ButtonSaveCategory" runat="server" Text="Save" OnClick="ButtonSaveCategory_Click"/>
    <br />
    <asp:ListBox ID="ListBoxCategories" runat="server" Rows="10"></asp:ListBox>
   
</asp:Content>
