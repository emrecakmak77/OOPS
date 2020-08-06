using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.DTO.Employee;
using OOPS.Model.EmployeeModel;

namespace OOPS.WebUI.Controllers
{
    public class OvertimeController : BaseController
    {
        private IOvertimeService service;
        private IEmployeeService employeeservice;
        public OvertimeController(IOvertimeService _service, IEmployeeService _employeeservice)
        {
            service = _service;
            employeeservice = _employeeservice;
        }

        [HttpPost]
        public IActionResult AddOvertime(OvertimeDTO overtimeDto)
        {
            if (overtimeDto.EmployeeId == 0)
            {
                var emp = employeeservice.getEmployeeUser(CurrentUser.Id);
                overtimeDto.EmployeeId = emp.Id;
            }
            service.newOvertime(overtimeDto);
            return RedirectToAction("Index", "Home");
        }
    }
}
