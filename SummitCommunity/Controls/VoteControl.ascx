<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VoteControl.ascx.cs" Inherits="SummitCommunity.Controls.VoteControl" %>

<asp:UpdatePanel runat="server" ID="ControlWrapper">
    <ContentTemplate>
        <div class="like-control col-md-1">
            <div>Likes</div>
            <div>
                <asp:LinkButton runat="server" ID="ButtonLike" CssClass="btn btn-success glyphicon glyphicon-chevron-up" 
                    CommandArgument="<%# this.DataId %>" 
                    CommandName="Like" 
                    OnCommand="ButtonLike_Command" />
                <asp:Label runat="server" ID="LabelValue" CssClass="like-value" />
                <asp:LinkButton runat="server" ID="ButtonDislike" CssClass="btn btn-danger glyphicon glyphicon-chevron-down" 
                    CommandArgument="<%# this.DataId %>" 
                    CommandName="Dislike" 
                    OnCommand="ButtonLike_Command" />
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>