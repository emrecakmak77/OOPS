using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class EmployeeOverTimeDTO
    {
        public int EmployeeId { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
        public int OvertimeId { get; set; }
        public virtual OvertimeDTO Overtime { get; set; }

    }
}
