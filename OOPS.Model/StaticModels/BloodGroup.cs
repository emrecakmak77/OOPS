using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class BloodGroup : Entity<int>
    {
        public BloodGroup()
        {
            EmployeeDetails = new HashSet<EmployeeDetail>();
        }
        public string BloodKind { get; set; }
        public virtual ICollection<EmployeeDetail> EmployeeDetails { get; set; }

    }
}
