<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SummitCommunity._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Summit Communities</h1>
        <p class="lead">The Web App that brings communities together! <br />
            <strong>Take part in the hottest discussions. Your opinion maters! </strong>
        </p>
    </div>
    
    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>

    <div class="row">

        <div class="col-md-4">
            <h3>News</h3>
            <div class="list-group">
              <a href="#" class="list-group-item">
                Cras justo odio
              </a>
              <a href="#" class="list-group-item">Dapibus ac facilisis in</a>
              <a href="#" class="list-group-item">Morbi leo risus</a>
              <a href="#" class="list-group-item">Porta ac consectetur ac</a>
              <a href="#" class="list-group-item">Vestibulum at eros</a>
            </div>
        </div>

        <div class="col-md-8">
            <h2>Latest topics</h2>
            <asp:Repeater id="RepeaterCategories" runat="server">
        
                <ItemTemplate>
                    <div class="col-md-6">
                        <asp:Label ID="LabelLatestTopic1" runat="server">Topic 1</asp:Label>
                    </div>
                    <div class="col-md-2">
                        <asp:Label ID="LabelLatestTopic1Cat" runat="server">Category 1</asp:Label>
                    </div>
                </ItemTemplate>
     
        </asp:Repeater>

            <table class="table" Style='width:100%'>
                <tr>
                    <td Style='width:70%'>Topic 1</td>
                    <td Style='width:30%'>Category 1</td>
                </tr>
                <tr>
                    <td>Topic 2</td>
                    <td>Category 2</td>
                </tr>
                <tr>
                    <td>Topic 3</td>
                    <td>Category 2</td>
                </tr>
                <tr>
                    <td>Topic 4</td>
                    <td>Category 1</td>
                </tr>
                <tr>
                    <td>Topic 5</td>
                    <td>Category 3</td>
                </tr>
            </table>
        </div>
    </div>     

</asp:Content>
