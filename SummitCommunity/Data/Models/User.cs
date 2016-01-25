namespace SummitCommunity.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    // You can add User data for the user by adding more properties to your User class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class User : IdentityUser
    {
        private const int NameLength = 50;

        private ICollection<Question> questions;
        private ICollection<Answer> answers;

        public User()
        {
            this.questions = new HashSet<Question>();
            this.answers = new HashSet<Answer>();
        }

        [Required]
        [MaxLength(NameLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(NameLength)]
        public string LastName { get; set; }

        public virtual ICollection<Question> Questions
        {
            get { return this.questions; }
            set { this.questions = value; }
        }

        public virtual ICollection<Answer> Answers
        {
            get { return this.answers; }
            set { this.answers = value; }
        }

        public ClaimsIdentity GenerateUserIdentity(ApplicationUserManager manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(ApplicationUserManager manager)
        {
            return Task.FromResult(this.GenerateUserIdentity(manager));
        }
    }
}