using helpful.Core.Repositories;
using helpful.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace helpful.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected AppDbContext _Context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(AppDbContext context)
        {
            _Context = context;
            _dbSet =_Context.Set<T>();
        }


        public async Task AddAsync(T entity)
        {
             await _dbSet.AddAsync(entity);
        }

        public  IQueryable<T> GetAll()
        {
           return  _dbSet.AsNoTracking().AsQueryable();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public  IQueryable<T> GetListFilter(Expression<Func<T, bool>> expression)
        {
          return   _dbSet.Where(expression);
        }

        public  void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
