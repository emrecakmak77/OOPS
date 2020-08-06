using OOPS.DTO.Employee;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Company
{
    public class CompanyBranchDTO
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public string MersisNumber { get; set; }
        public string SSNumber { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public virtual CompanyDTO Company { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public virtual DistrictDTO District { get; set; }
        public string Adress { get; set; }
        public virtual List<EmployeeDTO> Employees { get; set; }
        public virtual List<PositionDTO> Positions { get; set; }

    }
}
