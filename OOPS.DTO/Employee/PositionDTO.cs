using OOPS.DTO.Company;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class PositionDTO
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public virtual CompanyDTO Company { get; set; }

        public Nullable<int> CompanyBranchID { get; set; }
        public virtual CompanyBranchDTO CompanyBranch { get; set; }

        public Nullable<int> CompanyDepartmentID { get; set; }
        public virtual CompanyDepartmentDTO CompanyDepartment { get; set; }

        public Nullable<int> EmploymentTypeID { get; set; }
        public virtual EmploymentTypeDTO EmploymentType { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual List<EmployeePositionDTO> EmployeePositions { get; set; }
    }
}
