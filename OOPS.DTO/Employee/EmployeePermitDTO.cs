using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class EmployeePermitDTO
    {
        public int EmployeeId { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
        public int PermitId { get; set; }
        public virtual PermitDTO Permit { get; set; }
    }
}
