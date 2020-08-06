using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Static
{
    public class AccessTypeDTO
    {
        public int Id { get; set; }
        public string AccessTypeName { get; set; }
        public virtual List<EmployeeDTO> Employees { get; set; }
    }
}
