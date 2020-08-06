using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Static
{
    public class ContractTypeDTO
    {
        public int Id { get; set; }
        public string ContractName { get; set; }
        public virtual List<EmployeeDTO> Employees { get; set; }
    }
}
