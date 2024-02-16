using helpful.Core.Entities;
using helpful.Core.Repositories;
using helpful.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpful.Repository.Repositories
{
    public class SectionRepository : GenericRepository<Section>, ISectionRepository
    {
        public SectionRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Section>> GetSectionWithCityCategory()
        {
            return await _Context.Sections.Include(x=>x.Category).Include(x=>x.CityId).OrderByDescending(x=>x.SectionDate).Take(5).ToListAsync();
        }

        public async Task<List<Section>> GetListSectionWithCityCategory(int categoryid, int cityid)
        {
            return await _Context.Sections.Include(x=>x.City).Include(x=>x.Category).Where(x=>x.CityId == cityid && x.CategoryId==categoryid).ToListAsync();
        }
    }
}
