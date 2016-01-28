namespace SummitCommunity.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using SummitCommunity.Data.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System;
    internal sealed class Configuration : DbMigrationsConfiguration<SummitCommunityDbContext>
    {
        private static Random random = new Random();

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
                new Category { Name = "Entrepreneuring" },
                new Category { Name = "Snowboarding" }
            };

            foreach (var cat in categories)
            {
                context.Categories.AddOrUpdate(cat);
            }

            context.SaveChanges();

            var users = new List<User>();

            for (int i = 0; i < 50; i++)
            {
                var user = new User
                {
                    UserName = "anonimous" + i,
                    Email = i + "anonimous@anonimous.com",
                    FirstName = "Anonymous" + i,
                    LastName = "Snow" + i
                };

                users.Add(user);
                context.Users.Add(user);
            }

            context.SaveChanges();

            var questions = new List<Question>();

            for (int i = 0; i < 10; i++)
            {
                var question = new Question
                {
                    Title = "Question" + i,
                    Content = "What to do with my question? Can someone answer me, please ?!",
                    Category = categories[i % 3],
                    CategoryId = categories[i % 3].Id,
                    User = users[i],
                    UserId = users[i].Id,
                };

                questions.Add(question);
            }

            var votes = new List<Vote>();

            for (int i = 0; i < 50; i++)
            {
                var vote = new Vote
                {
                    Question = questions[i % 9],
                    QuestionId = questions[i % 9].Id,
                    User = users[i],
                    UserId = users[i].Id,
                    Value = random.Next(-1, 2)
                };

                context.Votes.Add(vote);
                context.SaveChanges();
            }

            questions.ForEach(q =>
            {
                q.AverageVote = q.Votes.Sum(v => v.Value);
                context.Questions.AddOrUpdate(q);
            });
            context.SaveChanges();

            for (int i = 0; i < questions.Count - 2; i++)
            {
                if (i % 2 == 0)
                {
                    var answerOne = new Answer
                    {
                        Content = "I'm answering now.Read me!",
                        User = users[random.Next(0, 50)],
                        UserId = users[random.Next(0, 50)].Id,
                        Question = questions[i],
                        QuestionId = questions[i].Id
                    };

                    context.Answers.Add(answerOne);
                }

                var answerTwo = new Answer
                {
                    Content = i + " Let's answer this question.This is the correct answer!",
                    User = users[random.Next(0, 50)],
                    UserId = users[random.Next(0, 50)].Id,
                    Question = questions[i],
                    QuestionId = questions[i].Id
                };



                context.Answers.Add(answerTwo);
            }

            context.SaveChanges();
        }
    }
}
