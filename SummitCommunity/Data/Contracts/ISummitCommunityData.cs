namespace SummitCommunity.Data.Contracts
{
    using SummitCommunity.Data.Models;

    public interface ISummitCommunityData
    {
        IRepository<User> Users { get; }

        IRepository<Answer> Answers { get; }

        IRepository<Category> Categories { get; }

        IRepository<Question> Questions { get; }

        IRepository<Vote> Votes { get; }
        
        void SaveChanges();
    }
}
