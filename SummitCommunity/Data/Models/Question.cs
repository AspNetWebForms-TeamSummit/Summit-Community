namespace SummitCommunity.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    public class Question
    {
        private ICollection<Answer> answers;
        private ICollection<Vote> votes;
        private int averageVote;

        public Question()
        {
            this.CreatedOn = DateTime.Now;
            this.answers = new HashSet<Answer>();
            this.votes = new HashSet<Vote>();
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedOn { get; private set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Answer> Answers
        {
            get { return this.answers; }
            set { this.answers = value; }
        }

        public virtual ICollection<Vote> Votes
        {
            get { return this.votes; }
            set { this.votes = value; }
        }

        public int AverageVote
        {
            get { return this.averageVote; }
            set { this.averageVote = this.Votes.Sum(v => v.Value); }
        }
    }
}