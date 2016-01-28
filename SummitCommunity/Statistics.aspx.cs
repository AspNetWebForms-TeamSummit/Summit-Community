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
                var topic = this.Data.Questions.All().OrderByDescending(q => q.Votes.Sum(v => v.Value)).FirstOrDefault();
                topicString = topic?.Title + ":   Vote  " + topic?.Answers.Count.ToString();
                this.Cache.Insert("TopTopics", topicString, null, DateTime.Now.AddMinutes(15d), System.Web.Caching.Cache.NoSlidingExpiration);

            }

            return topicString;
        }

        private string GetMostDiscussedTopics()
        {
            var topicString = (string)this.Cache["MostDiscused"];
            if (topicString == null)
            {
                var topic = this.Data.Questions.All().OrderByDescending(q => q.Answers.Count).FirstOrDefault();
                topicString = topic?.Title + ":   " + topic?.Answers.Count.ToString() + "answers";
                this.Cache.Insert("MostDiscused", topicString, null, DateTime.Now.AddMinutes(15d), System.Web.Caching.Cache.NoSlidingExpiration);
            }

            return topicString;
        }
    }
}