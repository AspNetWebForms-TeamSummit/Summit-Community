<%@ Page Title="Statistics" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="SummitCommunity.Statistics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
      <h1><%: Title %> <small>Check the <strong>top</strong> and <strong>most</strong> of the communities.</small></h1>
    </div>

    <div class="panel panel-default">
        <!-- Default panel contents -->
        <div class="panel-heading">Most discussed topics:</div>

        <!-- Table -->
        <table class="table">
        ...
        </table>
    </div>

    <div class="panel panel-default">
        <!-- Default panel contents -->
        <div class="panel-heading">Top rated topics:</div>

        <!-- Table -->
        <div class="col-lg-12 ">  
            <div class="table-responsive">  
                <asp:GridView>

                </asp:GridView>
            </div>
        </div>
    </div>

    <div class="panel panel-default">
        <!-- Default panel contents -->
        <div class="panel-heading">Top rated users:</div>

        <!-- Table -->
        <table class="table">
        ...
        </table>
    </div>

    <div class="panel panel-default">
        <!-- Default panel contents -->
        <div class="panel-heading">Most active users:</div>

        <!-- Table -->
        <table class="table">
        ...
        </table>
    </div>
</asp:Content>
