using OOPS.Core.Business;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract
{
    public interface ISalaryService : IServiceBase
    {
        EmployeeSalaryDTO getSalary(int Id);
        List<EmployeeSalaryDTO> getAllEmployeeSalaries();
        EmployeeSalaryDTO newSalary(EmployeeSalaryDTO Salary);
        EmployeeSalaryDTO updateSalary(EmployeeSalaryDTO Salary);
    }
}
