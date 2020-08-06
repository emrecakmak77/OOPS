using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class Gender : Entity<int>
    {
        public Gender()
        {
            EmployeeDetails = new HashSet<EmployeeDetail>();
        }
        public string GenderName { get; set; }
        public virtual ICollection<EmployeeDetail> EmployeeDetails { get; set; }
    }
}
