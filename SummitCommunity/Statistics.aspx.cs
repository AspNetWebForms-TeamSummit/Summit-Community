using Ninject;
using SummitCommunity.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SummitCommunity
{

    public partial class Statistics : System.Web.UI.Page
    {
        [Inject]
        public ISummitCommunityData Data { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            MostDiscussedTopics.Text = GetMostDiscussedTopics();
            TopRatedTopics.Text = GetTopratedTopics();
        }

        private string GetTopratedTopics()
        {
            string topicString;
            topicString = (string)Cache["TopTopics"];
            if (topicString == null)
            {
                var topic = this.Data.Questions.All().OrderByDescending(q => q.Votes.Sum(v => v.Value)).First();
                topicString = topic.Title + ":   Vote  " + topic.Answers.Count.ToString();
                Cache.Insert("TopTopics", topicString);
            }

            return topicString;
        }

        private string GetMostDiscussedTopics()
        {
            string topicString;
            topicString = (string)Cache["MostDiscused"];
            if (topicString == null)
            {
                var topic = this.Data.Questions.All().OrderByDescending(q => q.Answers.Count).First();
                topicString = topic.Title + ":   " + topic.Answers.Count.ToString() + "answers";
                Cache.Insert("MostDiscused", topicString);
            }

            return topicString;
        }
    }
}