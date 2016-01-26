<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewQuestion.aspx.cs" Inherits="SummitCommunity.ViewQuestion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>View Question by id</h1>
    <asp:FormView ID="FormViewQuestionDetails" runat="server"
        ItemType="SummitCommunity.Data.Models.Question"
        SelectMethod="FormViewQuestionDetails_GetItem">
        <ItemTemplate>
            <h3><%#: Item.Title %></h3>
            <table border="0">
                <tr>
                    <td>Author:</td>
                    <td><%#: Item.User.FirstName + " " + Item.User.LastName %></td>
                </tr>
                <tr>
                    <td>Category:</td>
                    <td><%#: Item.Category.Name %></td>
                </tr>
                <tr>
                    <td>Content:</td>
                    <td><%#: Item.Content %></td>
                </tr>
                <tr>
                    <td>Created On:</td>
                    <td><%#: Item.CreatedOn %></td>
                </tr>
                <tr>
                    <td>Vote:</td>
                    <td><%#: Item.Vote %></td>
                </tr>
                <tr>
                    <td>Answers count:</td>
                    <td><%#: Item.Answers.Count %></td>
                </tr>
            </table>
            <hr />
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
