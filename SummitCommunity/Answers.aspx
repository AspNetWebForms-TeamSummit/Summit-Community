<%@ Page Title="Answers" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Answers.aspx.cs" Inherits="SummitCommunity.Answers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
      <h1>The topic "Bla"</h1>
    </div>

    <div class="row">
        <div class="col-md-3">
            <asp:Button ID="Upvote" runat="server" Text="Up" class="btn btn-default"></asp:Button>
            <asp:Button ID="Downvote" runat="server" Text="Down" class="btn btn-default"></asp:Button>
            <asp:Label ID="likes" runat="server" class="badge">65</asp:Label>
        </div>
        <div class="col-md-9">
            <p>Content of the question</p>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3 col-md-offset-9">
            by <asp:Label ID="theUser" runat="server" class="align-right">User123</asp:Label>
        </div>
    </div>
    

    <div class="row">
        <h3>Answers</h3>

      <asp:ListView ID="ListViewAnswers"
        runat="server">
        <LayoutTemplate>
          <table cellpadding="2" width="640px" border="1" ID="tableAnswers" runat="server" class="table">
            <tr runat="server">
              <th runat="server">Vote</th>
              <th runat="server">content</th>
              <th runat="server">user</th>
              <th runat="server">date</th>
            </tr>
            <tr runat="server" id="itemPlaceholder" />
          </table>
          <asp:DataPager ID="DataPager1" runat="server">
            <Fields>
              <asp:NumericPagerField />
            </Fields>
          </asp:DataPager>
        </LayoutTemplate>
        <ItemTemplate>
          <tr runat="server">
            <td>
              <asp:Label ID="VoteLabel" runat="server" Text='<%# Eval("VendorID") %>' />
            </td>
            <td>
              <asp:Label ID="ContentLabel" runat="server" Text='<%# Eval("AccountNumber") %>' />
            </td>
            <td>
              <asp:Label ID="UserLabel" runat="server" Text='<%# Eval("Name") %>' /></td>
            <td>
              <asp:Label ID="dateLabel" runat="server" Text='<%# Eval("date") %>'/>
            </td>
          </tr>
        </ItemTemplate>
      </asp:ListView>
    </div>

    <!-- Visible only for registered users-->

    <div class="row">
        <p>Add new answer: </p>
        <div>
            <asp:TextBox ID="TextBoxAddAnswer" runat="server" TextMode="MultiLine" Height="50px" Width="1009px"></asp:TextBox>
        </div>
        <div class="col-md-3 col-md-offset-9">
            <asp:Button ID="ButtonSubmitAnswer" runat="server" Text="Submit" class="btn btn-default"></asp:Button>
        </div>
    </div>


</asp:Content>
