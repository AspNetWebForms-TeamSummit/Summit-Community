namespace SummitCommunity.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        private const int NameMaxLength = 100;

        private ICollection<Question> questions;

        public Category()
        {
            this.questions = new HashSet<Question>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public string FileName { get; set; }

        public string FileExtension { get; set; }

        public virtual ICollection<Question> Questions
        {
            get { return this.questions; }
            set { this.questions = value; }
        }
    }
}