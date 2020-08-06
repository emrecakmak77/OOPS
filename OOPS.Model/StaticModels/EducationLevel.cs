using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class EducationLevel : Entity<int>
    {
        public EducationLevel()
        {
            EmployeeDetails = new HashSet<EmployeeDetail>();
        }
        public string EducationLevelName { get; set; }
        public virtual ICollection<EmployeeDetail> EmployeeDetails { get; set; }
    }
}
