namespace SummitCommunity.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Question
    {
        private ICollection<Answer> answers;

        public Question()
        {
            this.CreatedOn = DateTime.Now;
            this.answers = new HashSet<Answer>();
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
        
        public DateTime CreatedOn { get; private set; }
        
        public int Vote { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
        
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Answer> Answers
        {
            get { return this.answers; }
            set { this.answers = value; }
        }
    }
}