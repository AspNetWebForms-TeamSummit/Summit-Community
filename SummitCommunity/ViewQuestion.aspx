<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewQuestion.aspx.cs" Inherits="SummitCommunity.ViewQuestion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-center">
        <asp:ListView ID="ListViewQuestionDetails" runat="server"
            ItemType="SummitCommunity.Data.Models.Question"
            SelectMethod="ListViewQuestionDetails_GetItem">
            <ItemTemplate>
                <h3><%#: Item.Title %></h3>
                <div class="row">
                    <div class="col-md-6 col-md-offset-3">
                        <p>Author: <%#: Item.User.FirstName + " " + Item.User.LastName %></p>
                        <p>Category: <%#: Item.Category.Name %></p>
                        <p>Content: <%#: Item.Content %></p>
                        <p>Created On: <%#: Item.CreatedOn %></p>
                        <p>Vote: <%#: Item.Vote %></p>
                    </div>
                </div>
                <br />
                <asp:ListView runat="server" ID="ListViewAnswers"
                    ItemType="SummitCommunity.Data.Models.Answer"
                    SelectMethod="ListViewAnswers_GetData"
                    InsertMethod="ListViewAnswers_InsertItem"
                    InsertItemPosition="LastItem">
                    <LayoutTemplate>
                        <ul style="list-style-type: none">
                            <h4>Answers:</h4>
                            <br />
                            <li runat="server" id="itemPlaceHolder"></li>
                        </ul>
                    </LayoutTemplate>
                    <ItemSeparatorTemplate>
                        <hr />
                    </ItemSeparatorTemplate>
                    <ItemTemplate>
                        <li>
                            <asp:Label runat="server" Text="<%# Item.Content %>" />
                        </li>
                    </ItemTemplate>
                    <InsertItemTemplate>
                        <asp:Panel ID="PanelInsertAnswer" runat="server" 
                            Visible="<%# this.User.Identity.IsAuthenticated ? true : false %>">
                            <div class="row">
                                <p>
                                    <asp:TextBox runat="server" ID="TextBoxInsertContent"
                                        Width="500"
                                        TextMode="MultiLine"
                                        placeholder="Add answer to this question..."
                                        Text="<%#: BindItem.Content %>" Rows="6">
                                    </asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server"
                                        ErrorMessage="Content is Required!"
                                        ValidationGroup="InsertAnswer"
                                        ControlToValidate="TextBoxInsertContent"
                                        ForeColor="Red" />
                                </p>
                                <div>
                                    <asp:LinkButton runat="server" ID="ButtonInsertAnswer"
                                        CssClass="btn btn-success"
                                        CommandName="Insert"
                                        Text="Insert"
                                        CausesValidation="true"
                                        ValidationGroup="InsertAnswer" />
                                    <asp:LinkButton runat="server" ID="ButtonCancelAnswer"
                                        CssClass="btn btn-danger"
                                        CommandName="Cancel"
                                        Text="Cancel"
                                        CausesValidation="false" />
                                </div>
                            </div>
                        </asp:Panel>
                    </InsertItemTemplate>
                    <EmptyDataTemplate>
                        No answers given.
                    </EmptyDataTemplate>
                </asp:ListView>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
