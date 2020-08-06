using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.Employee;
using OOPS.DTO.Employee;

namespace OOPS.WebUI.Controllers
{
    public class AdvanceController : BaseController
    {
        private IAdvanceService advanceService;
        private IEmployeeService employeeService;

        public AdvanceController(IAdvanceService _advanceService, IEmployeeService _employeeService)
        {
            advanceService = _advanceService;
            employeeService = _employeeService;
        }
        [HttpPost]
        public IActionResult AddAdvance(AdvanceDTO advanceDTO)
        {
            EmployeeDTO emp;
            if (advanceDTO.EmployeeId == 0)
            {
                emp = employeeService.getEmployeeUser(CurrentUser.Id);
                advanceDTO.EmployeeId = emp.Id;
            }
            else
            {
                emp = employeeService.getEmployeeInfo(advanceDTO.EmployeeId);
            }

            string Name = emp.Name;
            Name += " ";
            string LastName = emp.Surname;
            advanceDTO.EmployeeFullName = String.Concat(Name, LastName);
            advanceService.newAdvance(advanceDTO);
            return RedirectToAction("Index", "Home");
        }
    }
}