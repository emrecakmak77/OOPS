using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.EmployeeAbstract;
using OOPS.DTO.Employee;
using OOPS.WebUI.Models;

namespace OOPS.WebUI.Controllers
{
    public class SalaryController : BaseController
    {
        private ISalaryService service;

        public SalaryController(ISalaryService _service)
        {
            service = _service;
        }

        [HttpPost]
        public IActionResult AddSalary(EmployeeModel emp)
        {    
            
            service.newSalary(new EmployeeSalaryDTO() { EmployeeID = emp.Employee.Id, Amount = emp.EmployeeSalary.Amount});
            return RedirectToAction("List", "Employee");
        }
    }
}