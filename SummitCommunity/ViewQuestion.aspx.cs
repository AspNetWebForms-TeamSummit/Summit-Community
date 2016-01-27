using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Ninject;
using SummitCommunity.Data.Contracts;
using SummitCommunity.Data.Models;

namespace SummitCommunity
{
    public partial class ViewQuestion : Page
    {
        [Inject]
        public ISummitCommunityData Data { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public Question ListViewQuestionDetails_GetItem([QueryString]int id)
        {
            return this.Data.Questions.GetById(id);
        }

        public void ListViewAnswers_InsertItem([QueryString]int id)
        {
            if (this.User == null || !this.User.Identity.IsAuthenticated)
            {
                return;
            }

            var question = this.Data.Questions.GetById(id);
            var answer = new Answer();
            var userId = HttpContext.Current.User.Identity.GetUserId();

            answer.QuestionId = question.Id;
            answer.Question = question;
            answer.UserId = userId;

            question.Answers.Add(answer);

            TryUpdateModel(answer);
            if (ModelState.IsValid)
            {
                this.Data.Answers.Add(answer);
                this.Data.Questions.GetById(id).Answers.Add(answer);
                this.Data.SaveChanges();
            }
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Answer> ListViewAnswers_GetData([QueryString]int id)
        {
            return this.Data.Questions.GetById(id).Answers.OrderBy(a=>a.CreatedOn).AsQueryable();
        }
    }
}