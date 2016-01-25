namespace SummitCommunity.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Microsoft.AspNet.Identity.EntityFramework;
    using SummitCommunity.Data.Contracts;
    using SummitCommunity.Data.Migrations;
    using SummitCommunity.Data.Models;

    public class SummitCommunityDbContext : IdentityDbContext<User>, ISummitCommunityDbContext
    {
        private static readonly SummitCommunityDbContext context = new SummitCommunityDbContext();

        public SummitCommunityDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SummitCommunityDbContext, Configuration>());
        }

        public virtual IDbSet<Category> Categories { get; set; }

        public virtual IDbSet<Question> Questions { get; set; }

        public virtual IDbSet<Answer> Answers { get; set; }

        public static SummitCommunityDbContext Create()
        {
            return context;
        }

        IDbSet<T> ISummitCommunityDbContext.Set<T>()
        {
            return this.Set<T>();
        }

        DbEntityEntry ISummitCommunityDbContext.Entry<T>(T entity)
        {
            return this.Entry<T>(entity);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>()
                .HasRequired(a => a.User)
                .WithMany(u => u.Answers)
                .HasForeignKey(a => a.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        }
    }
}