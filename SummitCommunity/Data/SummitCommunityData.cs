namespace SummitCommunity.Data
{
    using System;
    using System.Collections.Generic;
    using SummitCommunity.Data.Contracts;
    using SummitCommunity.Data.Models;

    public class SummitCommunityData : ISummitCommunityData
    {
        private readonly ISummitCommunityDbContext context;
        private readonly IDictionary<Type, object> repositories = new Dictionary<Type, object>();

        public SummitCommunityData(ISummitCommunityDbContext context)
        {
            this.context = context;
        }

        public IRepository<User> Users => this.GetRepository<User>();

        public IRepository<Category> Categories => this.GetRepository<Category>();

        public IRepository<Question> Questions => this.GetRepository<Question>();

        public IRepository<Answer> Answers => this.GetRepository<Answer>();

        public IRepository<Vote> Votes => this.GetRepository<Vote>();

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        protected IRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeOfModel];
        }
    }
}