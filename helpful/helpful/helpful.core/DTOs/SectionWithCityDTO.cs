using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpful.Core.DTOs
{
    public class SectionWithCityDTO
    {
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? Place { get; set; }
        public string? HelperName { get; set; }
        public string? HelperSurname { get; set; }
        public string? HelperPhoneNumber { get; set; }
        public DateTime SectionDate { get; set; }

        public List<CityDTO> Cities { get; set; }

        public List<CategoryDTO> Categories { get; set; }
    }
}
