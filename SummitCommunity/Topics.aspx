<%@ Page Title="Topics" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Topics.aspx.cs" Inherits="SummitCommunity.Topics" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h1><%: Title %> <small>in <strong>
            <asp:Label ID="LabelCategory" runat="server"></asp:Label></strong></small></h1>
    </div>
    <div class="row">
        <div class="col-md-8">
            <asp:TextBox ID="TextBoxSearch" runat="server" class="form-control col-md-8" placeholder="Search" Style="width: 800px"></asp:TextBox>
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
            AutoGenerateColumns="false"
            GridLines="None"
            Font-Size="X-Large">
            <Columns>
                <asp:TemplateField HeaderText="Vote" SortExpression="AverageVote">
                    <ItemTemplate>
                        <%# Item.Votes.Sum(v=>v.Value) %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:HyperLinkField HeaderText="Title" DataTextField="Title"
                    DataNavigateUrlFields="Id"
                    DataNavigateUrlFormatString="~/ViewQuestion?id={0}" />
                <asp:BoundField DataField="User.FirstName" HeaderText="User" />
                <asp:BoundField DataField="CreatedOn" HeaderText="Created on" SortExpression="CreatedOn" DataFormatString="{0:d}" />
            </Columns>
        </asp:GridView>
    </div>
    <div class="row">
        Can`t find what you are looking for? Open a new topic:              
        <asp:Button ID="ButtonNewTopic" OnClick="ButtonNewTopic_Click" runat="server" class="btn btn-default" Text="New Topic" />
    </div>
    <div class="row col-md-4 col-md-offset-4">
        <div class="form-horizontal">
            <div class="form-group">
                <fieldset>
                    <asp:Panel runat="server" ID="PanelAddTopic"
                        Visible="false"
                        CssClass="panel">
                        <br />
                        <asp:Label runat="server" Text="Title"></asp:Label>
                        <asp:TextBox runat="server" ID="TextBoxTitle"
                            Text="Title"
                            CssClass="form-control" />
                        <br />
                        <asp:Label runat="server" Text="Content"></asp:Label>
                        <asp:TextBox runat="server" ID="TextBoxContent"
                            Text="Content"
                            CssClass="form-control" />
                        <br />
                        <asp:Label runat="server" Text="Category"></asp:Label>
                        <asp:DropDownList runat="server" ID="DropDownListTopicCategories"
                            DataTextField="Name"
                            DataValueField="Id"
                            CssClass="form-control"
                            Enabled="false">
                        </asp:DropDownList>
                        <br />
                        <asp:Button Text="Submit" runat="server"
                            OnClick="ButtonAddTopic_Click"
                            CssClass="btn btn-success" />
                        <asp:Button Text="Cancel" runat="server"
                            OnClick="ButtonCancelAddTopic_Click"
                            CssClass="btn btn-danger" />
                    </asp:Panel>
                </fieldset>
            </div>
        </div>
    </div>
</asp:Content>
