﻿using jet.Bean;
using jet.Repository.interfaces;
using jet.Config;
using Microsoft.EntityFrameworkCore;

namespace jet.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseBean
    {
        private readonly EFCoreContext _dbContext;

        public Repository(EFCoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual T GetById(string id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public virtual IEnumerable<T> List()
        {
            return _dbContext.Set<T>().AsEnumerable();
        }

        public virtual IEnumerable<T> List(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>()
                    .Where(predicate)
                    .AsEnumerable();
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Edit(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
