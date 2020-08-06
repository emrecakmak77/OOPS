using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using OOPS.Model.ProjectBaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.CompanyModels
{
    public class Company : Entity<int>
    {
        public Company()
        {
            Employees = new HashSet<Employee>();
            Users = new HashSet<User>();
            Positions = new HashSet<Position>();
            SystemEducations = new HashSet<SystemEducation>();
            CompanyBranches = new HashSet<CompanyBranch>();
            CompanyDepartments = new HashSet<CompanyDepartment>();
        }
        public string CompanyName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<CompanyBranch> CompanyBranches { get; set; }
        public virtual ICollection<CompanyDepartment> CompanyDepartments { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
        public virtual ICollection<SystemEducation> SystemEducations { get; set; }
    }
}
