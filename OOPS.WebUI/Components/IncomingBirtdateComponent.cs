using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.EmployeeAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class IncomingBirtdateViewComponent : ViewComponent
    {
        private readonly IEmployeeDetailService employeeDetailService;

        public IncomingBirtdateViewComponent (IEmployeeDetailService _employeeDetailService)
        {
            employeeDetailService = _employeeDetailService;
        }

        public IViewComponentResult Invoke()
        {
            //var companyId = CurrentUser.companyId;
            var companyId = 1;
            return View(employeeDetailService.getEmployeeDetail(companyId));
        }
    }
}
