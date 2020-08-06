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
    public class PositionController : BaseController
    {
        private IPositionService service;

        public PositionController(IPositionService _service, IEmployeePositionService _employeePositionService)
        {
            service = _service;
        }

        [HttpPost]
        public IActionResult AddPosition(EmployeeModel emp)
        {
            emp.Position.EmployeeId = emp.Employee.Id;
            service.newPosition(emp.Position);

            return RedirectToAction("List", "Employee");
        }
    }
}