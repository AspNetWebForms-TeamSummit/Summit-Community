<%@ Page Title="Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="SummitCommunity.Categories" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="page-header">
      <h1><%: Title %> <small>Choose a category you are interested in.</small></h1>
    </div>

        <div class="text-center">
            <asp:ListView runat="server" ID="ListViewCategories"
                ItemType="SummitCommunity.Data.Models.Category"
                SelectMethod="ListViewCategories_GetData"
                GroupItemCount="1">
                <LayoutTemplate>
                    <asp:PlaceHolder runat="server" ID="groupPlaceHolder"></asp:PlaceHolder>
                </LayoutTemplate>
                <GroupSeparatorTemplate>
                   
                </GroupSeparatorTemplate>
                <GroupTemplate>
                    <div class="row">
                        <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                    </div>
                </GroupTemplate>
                <ItemTemplate>
                    <itemtemplate>
                        <div class="col-md-3">
                            <div class="thumbnail">                     
                                <img src="https://lh5.ggpht.com/8cG5ON-bA4QdB-FA1ulXaK2eaPS7tXzxTr2w33YKzoHtGTGzKN4qhMEmq9lXD7sJGqQ=w300" 
                                    alt="<%#Item.Name %>""
                                    Style="width: 200px">
                                <div class="caption">
                                <h3> <%#: Item.Name %> <span class="badge"><%#this.GetQuestionsNumber(Item.Id) %></span></h3>
                                <p class="text-right"><a href="Topics" class="btn btn-default" role="button">Go to topics...</a></p>
                            </div>
                        </div>
                            <%--<h3><asp:hyperlink navigateurl='<%# "~/ViewQuestion?id=" + Item.Id %>' runat="server" Text="" /> <small><%#: Item.Category.Name %></small></h3>--%>       
                    </itemtemplate>
                </ItemTemplate>
            </asp:ListView>
        </div>
</asp:Content>
