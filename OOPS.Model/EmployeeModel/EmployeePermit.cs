using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class EmployeePermit : Entity<int>
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int PermitId { get; set; }
        public virtual Permit Permit { get; set; }
    }
}
