using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.CompanyModels
{
    public class CompanyBranch : Entity<int>
    {
        public CompanyBranch()
        {
            Employees = new HashSet<Employee>();
            Positions = new HashSet<Position>();
        }
        public string BranchName { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public string MersisNumber { get; set; }
        public string SSNumber { get; set; }

        [ForeignKey("Company")]
        public Nullable<int> CompanyID { get; set; }
        public virtual Company Company { get; set; }

        [ForeignKey("District")]
        public Nullable<int> DistrictId { get; set; }
        public virtual District District { get; set; }

        public string Adress { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Position> Positions { get; set; }


    }
}
