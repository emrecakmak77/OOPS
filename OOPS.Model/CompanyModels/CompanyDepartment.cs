using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.CompanyModels
{
    public class CompanyDepartment : Entity<int>
    {
        public CompanyDepartment()
        {
            Employees = new HashSet<Employee>();
            Positions = new HashSet<Position>();
        }
        public string Name { get; set; }

        [ForeignKey("Company")]
        public Nullable<int> CompanyID { get; set; }
        public virtual Company Company { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Position> Positions { get; set; }

    }
}
