﻿namespace SummitCommunity.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using SummitCommunity.Data.Contracts;

    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public GenericRepository(ISummitCommunityDbContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("An instance of ISummitCommunityDbContext is required to use this repository.", nameof(context));
            }

            this.Context = context;
            this.DbSet = this.Context.Set<TEntity>();
        }

        protected IDbSet<TEntity> DbSet { get; set; }

        protected ISummitCommunityDbContext Context { get; set; }

        public virtual IQueryable<TEntity> All()
        {
            return this.DbSet.AsQueryable();
        }

        public virtual TEntity GetById(object id)
        {
            return this.DbSet.Find(id);
        }

        public virtual void Add(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.DbSet.Add(entity);
            }
        }

        public virtual void Update(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            if (entry.State != EntityState.Deleted)
            {
                entry.State = EntityState.Deleted;
            }
            else
            {
                this.DbSet.Attach(entity);
                this.DbSet.Remove(entity);
            }
        }

        public virtual void Delete(object id)
        {
            var entity = this.GetById(id);

            if (entity != null)
            {
                this.Delete(entity);
            }
        }

        public virtual TEntity Attach(TEntity entity)
        {
            return this.Context.Set<TEntity>().Attach(entity);
        }

        public virtual void Detach(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Detached;
        }
    }
}