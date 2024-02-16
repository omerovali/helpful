using AutoMapper;
using helpful.Core.DTOs;
using helpful.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpful.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Section, SectionDTO>().ReverseMap();
            CreateMap<Section, SectionWithCityDTO>().ReverseMap();
            CreateMap<Category,CategoryDTO>().ReverseMap();
            CreateMap<City,CityDTO>().ReverseMap();
            
        }
    }
}
