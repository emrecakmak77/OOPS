using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Static
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Nullable<int> CountryId { get; set; }
        public virtual CountryDTO Country { get; set; }
        public List<DistrictDTO> Districts { get; set; }
        public List<EmployeeOtherInfoDTO> EmployeeOtherInfos { get; set; }

    }
}
