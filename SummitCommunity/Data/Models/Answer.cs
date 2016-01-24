namespace SummitCommunity.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Answer
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public int Vote { get; set; }
        
        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }
    }
}