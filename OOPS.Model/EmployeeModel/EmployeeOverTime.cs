using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class EmployeeOverTime : Entity<int>
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int OvertimeId { get; set; }
        public virtual Overtime Overtime { get; set; }
    }
}
