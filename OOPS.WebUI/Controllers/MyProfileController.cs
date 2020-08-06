using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;

namespace OOPS.WebUI.Controllers
{
    public class MyProfileController : BaseController
    {
        //private IEmployeeService service;
        public MyProfileController(IEmployeeService _service)
        {
            //service = _service;
        }
        public IActionResult Index()
        {
            return View(CurrentUser);
        }

        //[HttpPost]
        //public IActionResult Index(EmployeeDTO data)
        //{
        //    //ModelState.Remove("PhonePersonal");
        //    //ModelState.Remove("StartDate");
        //    //ModelState.Remove("ContractEndDate");
        //    //ModelState.Remove("AccessTypeID");
        //    //ModelState.Remove("ContractTypeID");

        //    //EmployeeDTO model =  service.getEmployeeInfo(data.Id);
        //    //model.Name = data.Name;
        //    //model.Surname = data.Surname;
        //    //model.EmployeePositions = data.EmployeePositions;
        //    //model.PhonePersonal = data.PhonePersonal;
        //    //model.EmailBusiness = data.EmailBusiness;
        //    //model.StartDate = data.StartDate;

        //    //if (ModelState.IsValid)
        //    //{
        //    //    service.updateEmployee(data);
        //    //}
        //    return View(data);
        //}
    }


}
