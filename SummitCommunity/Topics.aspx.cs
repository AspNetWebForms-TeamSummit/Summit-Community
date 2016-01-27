using Ninject;
using SummitCommunity.Data.Contracts;
using SummitCommunity.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SummitCommunity
{
    public partial class Topics : System.Web.UI.Page
    {
        [Inject]
        public ISummitCommunityData Data { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            string cat = Request.QueryString.GetValues("id")[0].ToString();
            LabelCategory.Text = GetCatgoryName(cat);
            GridViewTopics.Columns[0].ItemStyle.Width = new Unit(10, UnitType.Percentage);
            GridViewTopics.Columns[1].ItemStyle.Width = new Unit(60, UnitType.Percentage);            
            GridViewTopics.Columns[2].ItemStyle.Width = new Unit(15, UnitType.Percentage);
            GridViewTopics.Columns[3].ItemStyle.Width = new Unit(15, UnitType.Percentage);            
        }

        private string GetCatgoryName(string catId)
        {
            int categoryId = int.Parse(catId);
            string catName = this.Data.Categories.All().Where(c => c.Id == categoryId).Select(c => c.Name).FirstOrDefault().ToString();
            return catName;
        }

        public IQueryable<Question> GridViewTopics_GetData([QueryString]int id)
        {
             
            var query = this.Data.Questions
                .All()
                .Where(q => q.CategoryId == id)
                .OrderByDescending(d => d.CreatedOn);

            return query;               
        }
    }
}