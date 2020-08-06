using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class EducationStatus : Entity<int>
    {
        public EducationStatus()
        {
            EmployeeDetails = new HashSet<EmployeeDetail>();
        }
        public string StatusName { get; set; }
        public virtual ICollection<EmployeeDetail> EmployeeDetails { get; set; }
    }
}
