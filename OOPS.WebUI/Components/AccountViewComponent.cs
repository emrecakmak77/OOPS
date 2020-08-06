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
    public class AccountViewComponent : ViewComponent
    {
        private readonly IEmployeeService employeeService;
        public AccountViewComponent(IEmployeeService _employeeService)
        {
            employeeService = _employeeService;
        }

        public IViewComponentResult Invoke(int id)
        {
            return View("../MyProfile/Account", employeeService.getEmployeeUser(id));
        }

    }
}
