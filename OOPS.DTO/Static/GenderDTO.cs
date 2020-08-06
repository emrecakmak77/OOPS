using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Static
{
    public class GenderDTO
    {
        public int Id { get; set; }
        public string GenderName { get; set; }
        public virtual List<EmployeeDetailDTO> EmployeeDetails { get; set; }
    }
}
