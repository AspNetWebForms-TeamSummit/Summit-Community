namespace SummitCommunity.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using SummitCommunity.Data.Models;
    using System.Collections.Generic;
    using System.Linq;
    internal sealed class Configuration : DbMigrationsConfiguration<SummitCommunityDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SummitCommunityDbContext context)
        {
            if (context.Categories.Any())
            {
                return;
            }

            var categories = new List<Category> {
                new Category { Name = "Cooking" },
                new Category { Name = "Programming" },
                new Category { Name = "DIY" },
                new Category { Name = "Entrepreneuring" }
            };

            foreach (var cat in categories)
            {
                context.Categories.AddOrUpdate(cat);
            }

            context.SaveChanges();

            User user = new User
            {
                UserName = "anonimous@anonimous.com",
                Email = "anonimous@anonimous.com",
                FirstName = "Anonymous",
                LastName = "Snow"
            };

            context.Users.AddOrUpdate(user);
            context.SaveChanges();

            var questions = new List<Question>();

            for (int i = 0; i < 10; i++)
            {
                var question = new Question
                {
                    Title = "Question" + i,
                    Content = "What to do with my question? Can someone answer me, please ?!",
                    Category = categories[i%3],
                    CategoryId = categories[i%3].Id,
                    User = user,
                    UserId = user.Id
                };

                context.Questions.Add(question);
            }
            
            context.SaveChanges();
        }
    }
}
