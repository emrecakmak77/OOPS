using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class ContractType : Entity<int>
    {
        public ContractType()
        {
            Employees = new HashSet<Employee>();
        }
        public string ContractName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
