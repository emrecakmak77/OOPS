using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.EmployeeAbstract;
using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class MyVisasViewComponent : ViewComponent
    {
        private readonly IEmployeeService employeeService;
        private readonly IVisaDocumentRequestsService visaDocumentRequestsService;

        public MyVisasViewComponent(IEmployeeService _employeeService, IVisaDocumentRequestsService _visaDocumentRequestsService)
        {
            employeeService = _employeeService;
            visaDocumentRequestsService = _visaDocumentRequestsService;
        }

        public IViewComponentResult Invoke(int id)  //id alanı UserId ' yi temsil etmektedir.
        {
            var employee = employeeService.getEmployeeUser(id);
            var myVisas = visaDocumentRequestsService.getEmployeeVisaDocumentRequests(employee.Id);
            return View("../MyProfile/MyVisas", myVisas);
        }
       

    }
}
