namespace SummitCommunity.Data.Contracts
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using SummitCommunity.Data.Models;

    public interface ISummitCommunityDbContext
    {
        IDbSet<Category> Categories { get; set; }

        IDbSet<Question> Questions { get; set; }

        IDbSet<Answer> Answers { get; set; }

        IDbSet<Vote> Votes { get; set; }

        IDbSet<T> Set<T>() where T : class;

        DbEntityEntry Entry<T>(T entity) where T : class;

        int SaveChanges();

        void Dispose();
    }
}