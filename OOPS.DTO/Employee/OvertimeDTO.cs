using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class OvertimeDTO
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan StartHour { get; set; }
        public string OvertimeHour { get; set; }
        public string Description { get; set; }
        public virtual List<EmployeeOverTimeDTO> EmployeeOverTimes { get; set; }
    }
}
