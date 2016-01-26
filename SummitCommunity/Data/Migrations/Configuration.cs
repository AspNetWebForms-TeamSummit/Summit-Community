namespace SummitCommunity.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using SummitCommunity.Data.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SummitCommunityDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SummitCommunityDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Categories.AddOrUpdate(
                c => c.Name,
                new Category { Name = "Cooking" },
                new Category { Name = "Programming" },
                new Category { Name = "DIY" },
                new Category { Name = "Entrepreneuring" });

            context.Questions.AddOrUpdate(
                q => q.Title,
                new Question
                {
                    Title ="Salty Muffins",
                    Content = "Can someone please recommend a recipe for muffins with cheese?",
                    CategoryId = 1
                },
            new Question
            {
                Title = "Chocolate Muffins",
                Content = "Can someone please recommend a recipe for muffins with chocolate?",
                CategoryId = 1
            },
            new Question
            {
                Title = "Database seeding",
                Content = "I need to seed a MSSQL DB. Can you please tell me a smart way to do it?",
                CategoryId = 2
            });
        }
    }
}
