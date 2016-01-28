<%@ Page Title="Summit Community" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SummitCommunity._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <h1>Summit Communities</h1>
        <p class="lead">
            The Web App that brings communities together!
            <br />
            <strong>Take part in the hottest discussions. Your opinion maters! </strong>
        </p>
    </div>
    <div class="text-center">
        <asp:ListView runat="server" ID="ListViewPopularQuestions"
            ItemType="SummitCommunity.Data.Models.Question"
            SelectMethod="ListViewPopularQuestions_GetData"
            GroupItemCount="2">
            <LayoutTemplate>
                <h2>Most popular questions</h2>
                <asp:PlaceHolder runat="server" ID="groupPlaceHolder"></asp:PlaceHolder>
            </LayoutTemplate>
            <GroupSeparatorTemplate>
                <hr />
            </GroupSeparatorTemplate>
            <GroupTemplate>
                <div class="row">
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                </div>
            </GroupTemplate>
            <ItemTemplate>
                <itemtemplate>
                    <div class="col-md-6">
                        <h3><asp:hyperlink navigateurl='<%# "~/ViewQuestion?id=" + Item.Id %>' runat="server" Text="<%#: Item.Title %>" /> <small><%#: Item.Category.Name %></small></h3>
                        <p>
                            <%# Item.Content  %>
                        </p>
                        <p>Vote: <%#: Item.Votes.Sum(v => v.Value) %></p>
                        <div>
                            <i>by <%#: Item.User.FirstName + " " + Item.User.LastName %></i>
                            <i>created on: <%# Item.CreatedOn %></i>
                        </div>
                    </div>
                </itemtemplate>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
