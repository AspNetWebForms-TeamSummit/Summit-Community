using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SummitCommunity
{
    using System.Threading;
    using Data.Models;
    using Ninject;
    using SummitCommunity.Data;
    using SummitCommunity.Data.Contracts;

    public partial class _Default : Page
    {
        [Inject]
        public ISummitCommunityData Data { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //this.DropDownList1.DataSource = this.Data.Categories.All().Select(c => c.Name).ToList();
            //this.DropDownList1.DataBind();
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Question> ListViewPopularQuestions_GetData()
        {
            return this.Data.Questions.All().OrderByDescending(q => q.Votes.Sum(v => v.Value)).Take(6);
        }
    }
}