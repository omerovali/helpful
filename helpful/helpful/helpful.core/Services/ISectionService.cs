using helpful.Core.DTOs;
using helpful.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpful.Core.Services
{
    public interface ISectionService:IGenericService<Section>
    {
        Task<List<Section>> GetListSectionWithCityCategory(int categoryid, int cityid);
        Task<CustomResponseDTO<List<SectionWithCityDTO>>> GetListSectionWithCityCategory();
    }
}
    