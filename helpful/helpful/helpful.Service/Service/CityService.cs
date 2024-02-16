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
    public class CityService : GenericService<City>, ICityService
    {
        private readonly ICityService _cityService;
        public CityService(IGenericRepository<City> repository, IUnitOfWorks unitOfWork, ICityService cityService) : base(repository, unitOfWork)
        {
            _cityService = cityService;
        }
    }
}
