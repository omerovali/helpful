﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace helpful.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T entity);
        void Remove(T entity);
        void Update(T entity);
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetListFilter(Expression<Func<T,bool>> expression);


    }
}
