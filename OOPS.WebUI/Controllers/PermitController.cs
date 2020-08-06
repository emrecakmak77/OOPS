using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;
using OOPS.WebUI.Models;

namespace OOPS.WebUI.Controllers
{
    public class PermitController : BaseController
    {
        private IPermitService service;
        private IEmployeeService employeeservice;
        public PermitController(IPermitService _service, IEmployeeService _employeeservice)
        {
            service = _service;
            employeeservice = _employeeservice;
        }
       
        [HttpPost]
        public IActionResult AddPermit(PermitDTO permitDto)
        {
            if (permitDto.EmployeeId == 0)
            {
                var emp = employeeservice.getEmployeeUser(CurrentUser.Id);
                permitDto.EmployeeId = emp.Id;
            }
            service.newPermit(permitDto);
            return RedirectToAction("Index","Home");
        }
    }
}