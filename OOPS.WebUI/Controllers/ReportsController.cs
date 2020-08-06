using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Concreate.EmployeConcreate;

namespace OOPS.WebUI.Controllers
{
    public class ReportsController : BaseController
    {
        private readonly IEmployeeService _employeeService;
        private readonly ISalaryService _salaryService;
        private readonly IPermitService _permitService;
        public ReportsController(IEmployeeService employeeService, ISalaryService salaryService, IPermitService permitService)
        {
            _employeeService = employeeService;
            _salaryService = salaryService;
            _permitService = permitService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Employee(int? ReportsEmployeeId)
        {
            switch (ReportsEmployeeId)
            {
                case 1:
                    return View("Index");
                case 2:
                    var model = _employeeService.getCompanyEmployees((int)CurrentUser.CompanyID);
                    return View("ReportEmployeeList", model);
            }
            return View();
        }

        public IActionResult EmployeeFinance(int? FinanceEmployeeId)
        {
            switch (FinanceEmployeeId)
            {
                case 1:
                    return View("Index");
                case 2:
                    var model = _salaryService.getAllEmployeeSalaries();
                    return View("SalaryEmployeeList", model);
            }
            return View();
        }
        public IActionResult EmployeeAdministrative(int? AdministrativeEmployeeId)
        {
            switch (AdministrativeEmployeeId)
            {
                case 1:
                    return View("Index");
                case 2:
                    var model = _permitService.getEmployeePermits();
                    return View("PermitEmployeeList", model);
            }
            return View();
        }
    }
}