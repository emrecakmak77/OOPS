using OOPS.Core.Entities;
using OOPS.Model.CompanyModels;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class Position : Entity<int>
    {
        public Position()
        {
            EmployeePositions = new HashSet<EmployeePosition>();
        }

        [ForeignKey("Company")]
        public Nullable<int> CompanyID { get; set; }
        public virtual Company Company { get; set; }

        [ForeignKey("CompanyBranch")]
        public Nullable<int> CompanyBranchID { get; set; }
        public virtual CompanyBranch CompanyBranch { get; set; }


        [ForeignKey("CompanyDepartment")]
        public Nullable<int> CompanyDepartmentID { get; set; }
        public virtual CompanyDepartment CompanyDepartment { get; set; }

        [ForeignKey("EmploymentType")]
        public Nullable<int> EmploymentTypeID { get; set; }
        public virtual EmploymentType EmploymentType { get; set; }
        public int EmployeeId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<EmployeePosition> EmployeePositions { get; set; }

    }
}
