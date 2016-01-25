<%@ Page Title="Topics" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Topics.aspx.cs" Inherits="SummitCommunity.Topics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
      <h1><%: Title %> <small>in <strong>Category</strong></small></h1>
    </div>

    <div class="row">
        <div class="col-md-8">
            <asp:TextBox ID="TextBoxSearch" runat="server" class="form-control col-md-8" placeholder="Search" Style="width:800px"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <asp:Button ID="ButtonSearch" runat="server" class="btn btn-default" Text="Search" />
        </div>
        
    </div>
    <div class="row">
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>

    <div class="row">
        Can`t find what you are looking for?  <mark>Open a new topic: </mark>           
        <asp:Button ID="ButtonNewTopic" runat="server" class="btn btn-default" Text="New Topic" />
    </div>

</asp:Content>
