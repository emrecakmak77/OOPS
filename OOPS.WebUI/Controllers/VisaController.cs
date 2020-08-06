using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.DTO.Static;

namespace OOPS.WebUI.Controllers
{
    public class VisaController : BaseController
    {
        private IVisaDocumentRequestsService service;
        private IEmployeeService employeeService;

        public VisaController(IVisaDocumentRequestsService _service, IEmployeeService _employeeService)
        {
            service = _service;
            employeeService = _employeeService;
        }

        [HttpPost]
        public IActionResult AddVisa(VisaDocumentRequestDTO visaDocumentRequestDTO)
        {
            if (visaDocumentRequestDTO.EmployeeId == 0)
            {
                var emp = employeeService.getEmployeeUser(CurrentUser.Id);
                visaDocumentRequestDTO.EmployeeId = emp.Id;
            }
            service.newVisaDocumentRequest(visaDocumentRequestDTO);
            return RedirectToAction("Index", "Home");
        }
    }
}
