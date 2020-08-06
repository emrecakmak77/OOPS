using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class MyPermitsViewComponent : ViewComponent
    {
        private readonly IEmployeeService employeeService;
        private readonly IPermitService permitService;

        public MyPermitsViewComponent(IEmployeeService _employeeService, IPermitService _permitService)
        {
            employeeService = _employeeService;
            permitService = _permitService;
        }

        public IViewComponentResult Invoke(int id)  //id alanı UserId ' yi temsil etmektedir.
        {
            var employee = employeeService.getEmployeeUser(id);
            var myPermits = permitService.getEmployeePermits(employee.Id);
            return View("../MyProfile/MyPermits", myPermits);
        }
    }
}
