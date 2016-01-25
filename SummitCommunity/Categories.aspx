<%@ Page Title="Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="SummitCommunity.Categories" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="page-header">
      <h1><%: Title %> <small>Choose a category you are interested in.</small></h1>
    </div>

    <div class="row">
        <asp:Repeater id="RepeaterCategories" runat="server">
        
                <ItemTemplate>
                    <div class="col-md-3">
                        <div class="thumbnail">
                            <img src="https://lh5.ggpht.com/8cG5ON-bA4QdB-FA1ulXaK2eaPS7tXzxTr2w33YKzoHtGTGzKN4qhMEmq9lXD7sJGqQ=w300" 
                                alt="Javascript"
                                Style="width: 200px">
                            <div class="caption">
                            <h3>JavaScript <span class="badge">42</span></h3>
                            <p class="text-right"><a href="#" class="btn btn-default" role="button">Go to topics...</a></p>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
     
        </asp:Repeater>
    </div>

     <div class="row">
                <div class="col-md-3">
                    <div class="thumbnail">
                        
                        <img src="https://lh5.ggpht.com/8cG5ON-bA4QdB-FA1ulXaK2eaPS7tXzxTr2w33YKzoHtGTGzKN4qhMEmq9lXD7sJGqQ=w300" 
                            alt="Javascript"
                            Style="width: 200px">
                        <div class="caption">
                        <h3>JavaScript <span class="badge">42</span></h3>
                        <p class="text-right"><a href="Topics" class="btn btn-default" role="button">Go to topics...</a></p>
                        </div>
                    </div>
                </div>

         <div class="col-md-3">
                    <div class="thumbnail">
                        <img src="https://lh5.ggpht.com/8cG5ON-bA4QdB-FA1ulXaK2eaPS7tXzxTr2w33YKzoHtGTGzKN4qhMEmq9lXD7sJGqQ=w300" 
                            alt="Javascript"
                            Style="width: 200px">
                        <div class="caption">
                        <h3>JavaScript <span class="badge">42</span></h3>
                        <p class="text-right"><a href="#" class="btn btn-default" role="button">Go to topics...</a></p>
                        </div>
                    </div>
                </div>


         <div class="col-md-3">
                    <div class="thumbnail">
                        <img src="https://lh5.ggpht.com/8cG5ON-bA4QdB-FA1ulXaK2eaPS7tXzxTr2w33YKzoHtGTGzKN4qhMEmq9lXD7sJGqQ=w300" 
                            alt="Javascript"
                            Style="width: 200px">
                        <div class="caption">
                        <h3>JavaScript <span class="badge">42</span></h3>
                        <p class="text-right"><a href="#" class="btn btn-default" role="button">Go to topics...</a></p>
                        </div>
                    </div>
                </div>

         <div class="col-md-3">
                    <div class="thumbnail">
                        <img src="https://lh5.ggpht.com/8cG5ON-bA4QdB-FA1ulXaK2eaPS7tXzxTr2w33YKzoHtGTGzKN4qhMEmq9lXD7sJGqQ=w300" 
                            alt="Javascript"
                            Style="width: 200px">
                        <div class="caption">
                        <h3>JavaScript <span class="badge">42</span></h3>
                        <p class="text-right"><a href="#" class="btn btn-default" role="button">Go to topics...</a></p>
                        </div>
                    </div>
                </div>

         <div class="col-md-3">
                    <div class="thumbnail">
                        <img src="https://lh5.ggpht.com/8cG5ON-bA4QdB-FA1ulXaK2eaPS7tXzxTr2w33YKzoHtGTGzKN4qhMEmq9lXD7sJGqQ=w300" 
                            alt="Javascript"
                            Style="width: 200px">
                        <div class="caption">
                        <h3>JavaScript <span class="badge">42</span></h3>
                        <p class="text-right"><a href="#" class="btn btn-default" role="button">Go to topics...</a></p>
                        </div>
                    </div>
                </div>

             </div>
</asp:Content>
