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
    <br />
    <div class="row">
        <asp:GridView ID="GridViewTopics" runat="server" class="table table-hover"
            SelectMethod="GridViewTopics_GetData"
            ItemType="SummitCommunity.Data.Models.Question"
            AllowPaging="True" AllowSorting="True"
            DataKeyNames="Id"
            AutoGenerateEditButton="false" 
            AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Vote" HeaderText="Vote" />
                <asp:BoundField DataField="Title" HeaderText="Title"/>
                <asp:BoundField DataField="Category.Name" HeaderText="Category" />
                <asp:BoundField DataField="User.FirstName" HeaderText="User" />
                <asp:BoundField DataField="CreatedOn" HeaderText="Created on" SortExpression="CreatedOn" />
            </Columns>    
            <PagerStyle />
                  
        </asp:GridView>
    </div>

    <div class="row">
        Can`t find what you are looking for? Open a new topic:              
        <asp:Button ID="ButtonNewTopic" runat="server" class="btn btn-default" Text="New Topic" />
    </div>

</asp:Content>
