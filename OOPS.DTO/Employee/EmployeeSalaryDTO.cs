using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class EmployeeSalaryDTO
    {
        public int Id { get; set; }
        public string SalaryName { get; set; }
        public int Amount { get; set; }
        public int EmployeeID { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
    }
}
