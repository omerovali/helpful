using helpful.Core.Entities;
using helpful.Core.IUnitOfWorks;
using helpful.Core.Repositories;
using helpful.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpful.Service.Service
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        private readonly ICategoryService _categoryService;
        public CategoryService(IGenericRepository<Category> repository, IUnitOfWorks unitOfWork, ICategoryService categoryService) : base(repository, unitOfWork)
        {
            _categoryService = categoryService;
        }
    }
}
