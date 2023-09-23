﻿using Blog.Core.Entities;
using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Concretes
{
    public class Repository<T> : IRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext dbContext;

        public Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private DbSet<T> Table { get => dbContext.Set<T>(); }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            if (predicate != null)
                query = query.Where(predicate);

            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }

            return await query.ToListAsync();

        }

        //TASK = VOID
        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByGuidAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task GetByGuid(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }
    }
}
