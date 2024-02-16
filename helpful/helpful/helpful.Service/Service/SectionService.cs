using AutoMapper;
using helpful.Core.Entities;
using helpful.Core.IUnitOfWorks;
using helpful.Core.Repositories;
using helpful.Core.Services;
using helpful.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace helpful.Service.Service
{
    public class SectionService : GenericService<Section>, ISectionService
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly IMapper _mapper;
        public SectionService(IGenericRepository<Section> repository, IUnitOfWorks unitOfWork, ISectionRepository sectionRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _sectionRepository = sectionRepository;
            _mapper = mapper;
        }
            public async Task<CustomResponseDTO<List<SectionWithCityDTO>>> GetListSectionWithCityCategory()
        {
            var aidNotice = await _sectionRepository.GetSectionWithCityCategory();

            var aidNoticeDto = _mapper.Map<List<SectionWithCityDTO>>(aidNotice);
            return CustomResponseDTO<List<SectionWithCityDTO>>.Success(200, aidNoticeDto);
        }
        public async Task<List<Section>> GetListSectionWithCityCategory(int categoryid,int cityid)
        {
            return await _sectionRepository.GetListSectionWithCityCategory(categoryid,cityid);
        }


    }
}
