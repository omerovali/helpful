using helpful.Core.IUnitOfWorks;
using helpful.Core.Repositories;
using helpful.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace helpful.Service.Service
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWorks _unitOfWork;
        public GenericService(IGenericRepository<T> repository, IUnitOfWorks unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }


        public async Task<T> AddAsync(T entity)
        {
           await _repository.AddAsync(entity);
           await _unitOfWork.CommitAsync();
           return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }

        public  Task<T> GetByIdAsync(int id)
        {
           var values = _repository.GetByIdAsync(id);
            if (values == null)
            {
                throw new DirectoryNotFoundException($"{typeof(T).Name}({id}) not found");
            }
            return values;
        }

        public IQueryable<T> GetListFilter(Expression<Func<T, bool>> expression)
        {
            return _repository.GetListFilter(expression);
        }

        public async Task RemoveAsync(T entity)
        {
            _repository.Remove(entity);
            await _unitOfWork.CommitAsync();
            
        }

        public async Task UpdateAsync(T entity)
        {
           _repository.Update(entity);
            await _unitOfWork.CommitAsync();
        }
    }
}
