using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Static
{
    public class BloodGroupDTO
    {
        public int Id { get; set; }
        public string BloodKind { get; set; }
        public virtual List<EmployeeDetailDTO> EmployeeDetails { get; set; }
    }
}
