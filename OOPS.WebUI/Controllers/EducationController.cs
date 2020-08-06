using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.EmployeeAbstract;
using OOPS.DTO.Employee;
using OOPS.Model.EmployeeModel;

namespace OOPS.WebUI.Controllers
{
    public class EducationController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        private IEducationService service;

        private IEmployeeService employeeservice;

        public EducationController(IEducationService _service, IEmployeeService _emloyeeservice)
        {
            service = _service;
            employeeservice = _emloyeeservice;
        }


        public IActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEducation(EducationDTO educationDTO)
        {
            if (educationDTO.EducationsTypeID == 0)
            {
                var emp = employeeservice.getEmployeeUser(CurrentUser.Id);
                educationDTO.EducationsTypeID = emp.Id;
            }
            service.newEducation(educationDTO);
            return RedirectToAction("Index", "Home");

        }

    }
}