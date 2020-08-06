using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Static
{
    public class CountryDTO
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string LangCode { get; set; }
        public string Code { get; set; }

        public virtual List<CityDTO> Cities { get; set; }
        public virtual List<EmployeeOtherInfoDTO> EmployeeOtherInfos { get; set; }
    }
}
