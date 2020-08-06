using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class EmployeePositionDTO
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
        public int PositionId { get; set; }
        public virtual PositionDTO Position { get; set; }

    }
}
