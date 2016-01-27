using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SummitCommunity.Data;
using SummitCommunity.Data.Contracts;
using SummitCommunity.Data.Models;
using Ninject;

namespace SummitCommunity
{
    public partial class Categories : Page
    {

        [Inject]
        public ISummitCommunityData Data { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        public IQueryable<Category> ListViewCategories_GetData()
        {
            return this.Data.Categories.All();
        }

        public int GetQuestionsNumber(int categoryId)
        {
            return this.Data.Categories
                .All()
                .Where(c => c.Id == categoryId)
                .Select(c => c.Questions.Count)
                .FirstOrDefault();
        }

        //protected void GoToTopics_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect = "~/Topics?id=" + Category.Id;
        //}
    }
}