namespace SummitCommunity.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Answer
    {
        public Answer()
        {
            this.CreatedOn = DateTime.Now;
        }

        public int Id { get; set; }

        [Required]
        public string Content { get; set; }
        
        public DateTime CreatedOn { get; private set; }

        public int Vote { get; set; }
        
        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }
    }
}