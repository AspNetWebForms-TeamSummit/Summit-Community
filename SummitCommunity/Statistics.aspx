<%@ Page Title="Statistics" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="SummitCommunity.Statistics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
      <h1><%: Title %> <small>Check the <strong>top</strong> and <strong>most</strong> of the communities.</small></h1>
    </div>

    <div class="panel panel-default">
      <div class="panel-heading">
        <h3 class="panel-title">Most discussed topics:</h3>
      </div>
      <div class="panel-body">
        <strong><asp:Label runat="server" ID="MostDiscussedTopics"></asp:Label></strong>
      </div>
    </div>

    <div class="panel panel-default">
      <div class="panel-heading">
        <h3 class="panel-title">Top rated topics:</h3>
      </div>
      <div class="panel-body">
        <strong><asp:Label runat="server" ID="TopRatedTopics"></asp:Label></strong>
      </div>
    </div>

    <div class="panel panel-default">
      <div class="panel-heading">
        <h3 class="panel-title">Top rated topics:</h3>
      </div>
      <div class="panel-body">
        <asp:Label runat="server" ID="TopRatedUsers"></asp:Label>
      </div>
    </div>
    
    <div class="panel panel-default">
      <div class="panel-heading">
        <h3 class="panel-title">Most active users:</h3>
      </div>
      <div class="panel-body">
        <asp:Label runat="server" ID="MostActiveUsers"></asp:Label>
      </div>
    </div>
</asp:Content>
