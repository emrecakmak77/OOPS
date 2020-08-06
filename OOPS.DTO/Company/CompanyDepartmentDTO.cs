using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Company
{
    public class CompanyDepartmentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public virtual CompanyDTO Company { get; set; }
        public virtual List<EmployeeDTO> Employees { get; set; }
        public virtual List<PositionDTO> Positions { get; set; }
    }
}
