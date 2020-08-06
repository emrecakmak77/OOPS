using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class EmployeeAdvanceDTO
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
        public int AdvanceId { get; set; }
        public virtual AdvanceDTO Advance { get; set; }
    }
}
