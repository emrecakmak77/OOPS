using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Static
{
    public class EducationLevelDTO
    {
        public int Id { get; set; }
        public string EducationLevelName { get; set; }
        public virtual List<EmployeeDetailDTO> EmployeeDetails { get; set; }
    }
}
