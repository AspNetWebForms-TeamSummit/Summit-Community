namespace SummitCommunity.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using SummitCommunity.Data.Migrations;
    using SummitCommunity.Data.Models;

    public class SummitCommunityDbContext : IdentityDbContext<User>
    {
        public SummitCommunityDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SummitCommunityDbContext, Configuration>());
        }

        public static SummitCommunityDbContext Create()
        {
            return new SummitCommunityDbContext();
        }
    }
}