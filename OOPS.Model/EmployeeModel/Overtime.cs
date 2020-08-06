using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class Overtime : Entity<int>
    {
        public Overtime()
        {
            EmployeeOverTimes = new HashSet<EmployeeOverTime>();
        }
        public DateTime StartDate { get; set; }
        public TimeSpan StartHour { get; set; }
        public string OvertimeHour { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EmployeeOverTime> EmployeeOverTimes { get; set; }
    }
}
