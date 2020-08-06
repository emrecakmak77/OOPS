using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class DisabilitySituation : Entity<int>
    {
        public DisabilitySituation()
        {
            EmployeeDetails = new HashSet<EmployeeDetail>();
        }
        public string DisabilityName { get; set; }
        public virtual ICollection<EmployeeDetail> EmployeeDetails { get; set; }
    }
}
