using Ninject;
using SummitCommunity.Data.Contracts;
using SummitCommunity.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
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
        }

        public IQueryable<Question> GridViewTopics_GetData()
        {
            var query = this.Data.Questions
                .All()
                .Where(q => q.CategoryId == 1)
                .OrderByDescending(d => d.CreatedOn);

            return query;
               
        }
    }
}