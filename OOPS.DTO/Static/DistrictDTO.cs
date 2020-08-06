using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Static
{
    public class DistrictDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Nullable<int> CityId { get; set; }
        public virtual CityDTO City { get; set; }
        public virtual List<EmployeeOtherInfoDTO> EmployeeOtherInfos { get; set; }
    }
}
