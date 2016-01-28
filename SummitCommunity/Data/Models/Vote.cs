using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SummitCommunity.Data.Models
{
    public class Vote
    {
        [Key, Column(Order = 1)]
        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }

        [Key, Column(Order = 0)]
        public string UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public int Value { get; set; }
    }
}