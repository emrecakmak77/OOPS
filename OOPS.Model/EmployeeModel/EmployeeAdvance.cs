using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class EmployeeAdvance : Entity<int>
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int AdvanceId { get; set; }
        public virtual Advance Advance { get; set; }


    }
}
