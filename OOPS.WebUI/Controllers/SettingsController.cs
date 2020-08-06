using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.CompanyAbstract;
using OOPS.BLL.Abstract.EmployeeAbstract;
using OOPS.DTO.Company;
using OOPS.DTO.Employee;
using OOPS.WebUI.Models;

namespace OOPS.WebUI.Controllers
{
    public class SettingsController : BaseController
    {

        private ISystemEducationService service;
        private IEmployeeService employeeservice;
        private ICompanyService companyService;
        private ICompanyBranchService companyBranchService;
        private ICompanyDepartmentService companyDepartmentService;
        public SettingsController(ISystemEducationService _service, IEmployeeService _employeeservice, ICompanyService _companyService, ICompanyBranchService _companyBranchService, ICompanyDepartmentService _companyDepartmentService)
        {
            service = _service;
            employeeservice = _employeeservice;
            companyService = _companyService;
            companyBranchService = _companyBranchService;
            companyDepartmentService = _companyDepartmentService;
        }
        public IActionResult Index()
        {

            SettingsModel model = new SettingsModel();
            model.SystemEducation = new SystemEducationDTO();
            model.CompanyBranch = new CompanyBranchDTO();
            model.CompanyDepartment = new CompanyDepartmentDTO();
            model.Company = companyService.getCompanyInfo((int)CurrentUser.CompanyID);
            model.SystemEducation.Company = companyService.getCompany((int)CurrentUser.CompanyID);
            model.CompanyBranch.Company = companyService.getCompany((int)CurrentUser.CompanyID);
            model.CompanyBranch.CompanyID = CurrentUser.CompanyID;
            model.CompanyDepartment.CompanyID = CurrentUser.CompanyID;
            model.SystemEducation.CompanyID = CurrentUser.CompanyID;
            return View(model);
        }

        [HttpPost]
        public IActionResult AddSystemEducation(SettingsModel settingsModel)
        {
            settingsModel.SystemEducation.CompanyID = CurrentUser.CompanyID;
            service.newSystemEducation(settingsModel.SystemEducation);
            return RedirectToAction("Index");
        }

        public IActionResult ListSystemEducation()
        {
            int companyId = (int)CurrentUser.CompanyID;
            List<SystemEducationDTO> systemEducation = service.getAllSystemEducations(companyId);
            return View(systemEducation);
        }

        public ActionResult DeleteBranch(int Id)
        {

            companyBranchService.deleteCompanyBranch(Id);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteDepartment(int Id)
        {

            companyDepartmentService.deleteDepartmant(Id);
            return RedirectToAction("Index");
        }


    }
}
