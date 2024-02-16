using helpful.Core.Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpful.Core.Repositories
{
    public interface ISectionRepository : IGenericRepository<Section>
    {
        Task<List<Section>> GetListSectionWithCityCategory(int categoryid, int cityid);
        Task<List<Section>> GetSectionWithCityCategory();
    }
}
