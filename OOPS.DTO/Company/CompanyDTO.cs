using OOPS.DTO.ProjectBase;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Company
{
    public class CompanyDTO
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public virtual List<EmployeeDTO> Employees { get; set; }
        public virtual List<CompanyBranchDTO> CompanyBranches { get; set; }
        public virtual List<CompanyDepartmentDTO> CompanyDepartments { get; set; }
        public virtual List<UserDTO> Users { get; set; }
        public virtual List<PositionDTO> Positions { get; set; }
        public virtual List<SystemEducationDTO> SystemEducations { get; set; }

    }
}
