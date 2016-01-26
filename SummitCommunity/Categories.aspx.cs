using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SummitCommunity.Data;
using SummitCommunity.Data.Contracts;
using SummitCommunity.Data.Models;

namespace SummitCommunity
{
    public partial class Categories : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ISummitCommunityData data = new SummitCommunityData();
            var allCategories = data.Categories.All().ToList();

            RepeaterCategories.DataSource = allCategories;
            RepeaterCategories.DataBind();
        }



        
    }
}