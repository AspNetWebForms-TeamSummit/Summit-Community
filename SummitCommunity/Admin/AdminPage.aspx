<%@ Page Title="Administration" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="SummitCommunity.Admin.AdminPage" validateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Hello, admin!</h1>

    <asp:Label ID="LabelAddCategory" runat="server" Text="Add Category:"></asp:Label>
    <asp:TextBox ID="TextBoxAddCategory" runat="server"></asp:TextBox>
    <asp:FileUpload ID="FileControl" runat="server" />
    <asp:Button ID="ButtonSaveCategory" runat="server" Text="Save" OnClick="ButtonSaveCategory_Click"/>
    <hr />
            <asp:ListView runat="server" ID="CategoriesListView" ItemType="SummitCommunity.Data.Models.Category" DataKeyNames="Id"
                SelectMethod="CategoriesListView_GetData" InsertMethod="CategoriesListView_InsertItem"
                UpdateMethod="CategoriesListView_UpdateItem" DeleteMethod="CategoriesListView_DeleteItem">
                <ItemTemplate>
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                    <asp:Literal runat="server" Text="<%#: Item.Name %>"></asp:Literal>
                </ItemTemplate>
                <ItemSeparatorTemplate>
                    <hr />
                </ItemSeparatorTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="EditCategoryNameTextBox" runat="server" Text="<%#: BindItem.Name %>"></asp:TextBox>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <LayoutTemplate>
                    <ul id="itemPlaceholderContainer" runat="server" style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                        <li runat="server" id="itemPlaceholder" />
                    </ul>
                    <div style="text-align: center; background-color: #5D7B9D; font-family: Verdana, Arial, Helvetica, sans-serif; color: #FFFFFF;">
                        <asp:DataPager ID="DataPager1" runat="server">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                            </Fields>
                        </asp:DataPager>
                    </div>
                </LayoutTemplate>
            </asp:ListView>

   
</asp:Content>
