using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class EmployeePosition : Entity<int>
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

    }
}
