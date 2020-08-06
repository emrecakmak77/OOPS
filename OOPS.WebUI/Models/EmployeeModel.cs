using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Models
{
    public class EmployeeModel
    {
        public EmployeeDTO Employee { get; set; }
        public EmployeeDetailDTO EmployeeDetail { get; set; }
        public EmployeeOtherInfoDTO EmployeeOtherInfo { get; set; }
        public PositionDTO Position { get; set; }
        public EmployeePositionDTO EmployeePosition { get; set; }

        public EmployeeSalaryDTO EmployeeSalary { get; set; }
    }
}
