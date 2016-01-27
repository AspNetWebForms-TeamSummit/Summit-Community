namespace SummitCommunity
{
    using Ninject;
    using System;
    using System.Linq;
    using SummitCommunity.Data.Contracts;
    using SummitCommunity.Data.Models;

    public partial class Statistics : System.Web.UI.Page
    {
        [Inject]
        public ISummitCommunityData Data { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.MostDiscussedTopics.Text = this.GetMostDiscussedTopics();
            this.TopRatedTopics.Text = this.GetTopratedTopics();
        }

        private string GetTopratedTopics()
        {
            var topicString = (string)this.Cache["TopTopics"];
            if (topicString == null)
            {
                Question question = this.Data.Questions.All().OrderByDescending(q => q.Vote).FirstOrDefault();
                topicString = question?.Title + ":   Vote  " + question?.Answers.Count;
                this.Cache.Insert("TopTopics", topicString);
            }

            return topicString;
        }

        private string GetMostDiscussedTopics()
        {
            var topicString = (string)this.Cache["MostDiscused"];
            if (topicString == null)
            {
                Question question = this.Data.Questions.All().OrderByDescending(q => q.Answers.Count).FirstOrDefault();
                topicString = question?.Title + ":   " + question?.Answers.Count + " answers";
                this.Cache.Insert("MostDiscused", topicString);
            }

            return topicString;
        }
    }
}