namespace SummitCommunity
{
    using System;
    using System.Linq;
    using System.Web.UI;
    using Ninject;
    using SummitCommunity.Data.Contracts;
    using SummitCommunity.Data.Models;

    public partial class _Default : Page
    {
        [Inject]
        public ISummitCommunityData Data { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Question> ListViewPopularQuestions_GetData()
        {
            return this.Data.Questions.All().OrderByDescending(q => q.Vote).Take(6);
        }
    }
}