using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.CompanyAbstract;
using OOPS.BLL.Abstract.EmployeeAbstract;
using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;
using OOPS.WebUI.Models;
using OOPS.WebUI.Utils;

namespace OOPS.WebUI.Controllers
{
    public class EmployeeController : BaseController
    {
        private IEmployeeService service;
        private IEmployeeDetailService employeeDetailService;
        private IEmployeeOtherInfoService employeeOtherInfoService;
        private IBankAccountTypeService bankAccountTypeService;
        private IAccessTypeService accessTypeService;
        private IBloodGroupService bloodGroupService;
        private ICityService cityService;
        private IContractTypeService contractType;
        private ICountryService countryService;
        private IDisabilitySituationService disabilitySituationService;
        private IEducationLevelService educationLevelService;
        private IEducationStatusService educationStatusService;
        private IEmploymentTypeService employmentTypeService;
        private IGenderService genderService;
        private IMaritalStatusService maritalStatusService;
        private IPositionService positionService;
        private ICompanyService companyService;
        private ICompanyBranchService companyBranchService;
        private ICompanyDepartmentService companyDepartmentService;
        private IEmployeePositionService employeePositionService;
        public EmployeeController(IEmployeeService _service, IEmployeeDetailService _employeeDetailService, IEmployeeOtherInfoService _employeeOtherInfoService,
            IBankAccountTypeService _bankAccountTypeService, IAccessTypeService _accessTypeService, IBloodGroupService _bloodGroupService, ICityService _cityService,
            IContractTypeService _contractType, ICountryService _countryService, IDisabilitySituationService _disabilitySituationService, IEducationLevelService _educationLevelService,
            IEducationStatusService _educationStatusService, IEmploymentTypeService _employmentTypeService, IGenderService _genderService,
            IMaritalStatusService _maritalStatusService, IPositionService _positionService, ICompanyService _companyService, ICompanyBranchService _companyBranchService, ICompanyDepartmentService _companyDepartmentService,
            IEmployeePositionService _employeePositionService
            )
        {
            service = _service;
            employeeDetailService = _employeeDetailService;
            employeeOtherInfoService = _employeeOtherInfoService;
            employeePositionService = _employeePositionService;
            bankAccountTypeService = _bankAccountTypeService;
            accessTypeService = _accessTypeService;
            bloodGroupService = _bloodGroupService;
            cityService = _cityService;
            contractType = _contractType;
            countryService = _countryService;
            disabilitySituationService = _disabilitySituationService;
            educationLevelService = _educationLevelService;
            educationStatusService = _educationStatusService;
            employmentTypeService = _employmentTypeService;
            genderService = _genderService;
            maritalStatusService = _maritalStatusService;
            positionService = _positionService;
            companyService = _companyService;
            companyBranchService = _companyBranchService;
            companyDepartmentService = _companyDepartmentService;


        }

        public IActionResult Index()
        {
            var RoleName = CurrentUser.Role.Name;
            int companyId = (int)CurrentUser.CompanyID;

            //Giriş yapan kullanıcının EMployee Id boş degılse = ? Detail sayfasını çapırmak lazım.
            if (RoleName == "Admin")
            {
                return RedirectToAction(nameof(List));
            }
            else
            {
                return RedirectToAction(nameof(DetailEmployee));
            }
        }

        public IActionResult List()
        {
            int companyId = (int)CurrentUser.CompanyID;
            List<EmployeeDTO> employee = service.getCompanyEmployees(companyId);
            //o firmadli çalışanlar lsitelenecek
            return View(employee);
        }

        public IActionResult EditEmployee(int id)
        {
            int companyId = (int)CurrentUser.CompanyID;
            ViewBag.AccessType = new SelectList(accessTypeService.getAll(), "Id", "AccessTypeName");
            ViewBag.BankAccountType = new SelectList(bankAccountTypeService.getAll(), "Id", "BankAccountTypeName");
            ViewBag.BloodGroup = new SelectList(bloodGroupService.getAll(), "Id", "BloodKind");
            ViewBag.City = new SelectList(cityService.getAll(), "Id", "Name");
            ViewBag.ContractType = new SelectList(contractType.getAll(), "Id", "ContractName");
            ViewBag.Country = new SelectList(countryService.getAll(), "Id", "CountryName");
            ViewBag.Disability = new SelectList(disabilitySituationService.getAll(), "Id", "DisabilityName");
            ViewBag.EducationLevel = new SelectList(educationLevelService.getAll(), "Id", "EducationLevelName");
            ViewBag.EducationStatus = new SelectList(educationStatusService.getAll(), "Id", "StatusName");
            ViewBag.EmploymentType = new SelectList(employmentTypeService.getAll(), "Id", "EmploymentTypeName");
            ViewBag.Gender = new SelectList(genderService.getAll(), "Id", "GenderName");
            ViewBag.MaritalStatus = new SelectList(maritalStatusService.getAll(), "Id", "StatusName");
            ViewBag.Companies = new SelectList(companyService.getAll(companyId), "Id", "CompanyName");
            ViewBag.CompanyBranchs = new SelectList(companyBranchService.getSelectByCompanyId(companyId), "Id", "BranchName");
            ViewBag.CompanyDepartments = new SelectList(companyDepartmentService.getSelectByCompanyId(companyId), "Id", "Name");

            EmployeeModel model = new EmployeeModel();
            //TODO:employeePosition düzelt
            model.Employee = service.getEmployee(id);
            if (model.Employee.EmployeePositions.Count != 0)
            {
                model.Employee.EmployeePositions[0].Position = positionService.getPositions(id);
            }
            //model.Employee.EmployeePositions = positionService.getEmployeePosition(id);
            var empDetail = employeeDetailService.getEmployeeDetail(id);
            var empOtherInfo = employeeOtherInfoService.getEmployeeOtherInfo(id);
            if (empDetail == null)
            {
                model.EmployeeDetail = new EmployeeDetailDTO();
            }
            else
            {
                model.EmployeeDetail = empDetail;
            }
            if (empOtherInfo == null)
            {
                model.EmployeeOtherInfo = new EmployeeOtherInfoDTO();
            }
            else
            {
                model.EmployeeOtherInfo = empOtherInfo;
            }
            //kullanıcının detayı ve update işlemi

            return View(model);
        }

        [HttpPost]
        public IActionResult EditEmployee(EmployeeModel employeeModel)
        {
            service.updateEmployee(employeeModel.Employee);

            return RedirectToAction("List");
        }

        //EmployeeDetail Update and Add
        [HttpPost]
        public IActionResult EditEmployeedetail(EmployeeModel employeeModel)
        {
            if (employeeModel.EmployeeDetail.Id == null)
            {
                employeeModel.EmployeeDetail.EmployeeID = employeeModel.Employee.Id;
                employeeDetailService.newEmployeeDetail(employeeModel.EmployeeDetail);
            }
            else
            {
                employeeDetailService.updateEmployeeDetail(employeeModel.EmployeeDetail);
            }


            return RedirectToAction("List");
            //if (ModelState.IsValid)
            //{

            //}
            //else
            //{
            //    var errors = ModelState.Select(x => x.Value.Errors)
            //                 .Where(y => y.Count > 0)
            //                 .ToList();
            //    return View();
            //}
        }

        //EmployeeOtherInfo Update and Add
        [HttpPost]
        public IActionResult EditEmployeeOtherInfo(EmployeeModel employeeModel)
        {
            if (employeeModel.EmployeeOtherInfo.Id == null)
            {
                employeeModel.EmployeeOtherInfo.EmployeeID = employeeModel.Employee.Id;
                employeeOtherInfoService.newEmployeeOtherInfo(employeeModel.EmployeeOtherInfo);
            }
            else
            {
                employeeOtherInfoService.updateEmployeeOtherInfo(employeeModel.EmployeeOtherInfo);
            }
            return RedirectToAction("List");
        }



        //Giriş yapan Employee ise 
        public IActionResult DetailEmployee()
        {
            int userID = CurrentUser.Id;
            var empInfo = service.getEmployeeUser(userID);
            return View(empInfo);
        }

        public IActionResult AddEmployee()
        {
            EmployeeDTO emp = new EmployeeDTO();
            ViewBag.ContractType = new SelectList(contractType.getAll(), "Id", "ContractName");
            ViewBag.AccessType = new SelectList(accessTypeService.getAll(), "Id", "AccessTypeName");
            return View(emp);
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeDTO employee)
        {
            ViewBag.ContractType = new SelectList(contractType.getAll(), "Id", "ContractName");
            ViewBag.AccessType = new SelectList(accessTypeService.getAll(), "Id", "AccessTypeName");
            if (ModelState.IsValid)
            {
                var currentEmployee = service.getEmployeeUser(CurrentUser.Id);
                employee.CompanyID = (int)CurrentUser.CompanyID;
                employee.CompanyBranchID = currentEmployee.CompanyBranchID;
                employee.CompanyDepartmentId = currentEmployee.CompanyDepartmentId;
                service.newEmployee(employee);
                return RedirectToAction("List");
            }
            else
            {
                return View("AddEmployee", employee);
            }
        }

        public ActionResult<WebResponse> DeleteEmployee(int Id)
        {
            if (service.getEmployee(Id).User != null && CurrentUser.Id == service.getEmployee(Id).User.Id)
            {

                return new WebResponse() { Status = -1001, Message = "Giriş yapan kullanıcı kendini silemez" }; ;
            }
            var result = service.deleteEmployee(Id);
            if (result)
            {
                return RedirectToAction("List");
            }

            return new WebResponse() { Status = -9999, Message = "Beklenmeyen bir hata oluştu" }; ;
        }
    }
}