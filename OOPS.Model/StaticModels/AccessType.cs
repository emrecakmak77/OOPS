using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class AccessType : Entity<int>
    {
        public AccessType()
        {
            Employees = new HashSet<Employee>();
        }
        public string AccessTypeName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
