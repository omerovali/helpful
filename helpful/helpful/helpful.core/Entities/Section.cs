using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpful.Core.Entities
{
    public class Section:BaseEntity
    {
        public string Description { get; set; }
        public string Adress { get; set; }
        public string Place { get; set; }
        public string HelperName { get; set; }
        public string HelperSurname { get; set; }
        public string HelperPhoneNumber { get; set; }
        public DateTime SectionDate { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
    }
}
