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
    public class MyPaymentsViewComponent : ViewComponent
    {
        private readonly IEmployeeService employeeService;
        private readonly IPaymentsService paymentsService;

        public MyPaymentsViewComponent(IEmployeeService _employeeService, IPaymentsService _paymentsService)
        {
            employeeService = _employeeService;
            paymentsService = _paymentsService;
        }

        public IViewComponentResult Invoke(int id)  //id alanı UserId ' yi temsil etmektedir.
        {
            var employee = employeeService.getEmployeeUser(id);
            var myPayments = paymentsService.getEmployeePayments(employee.Id);
            return View("../MyProfile/MyPayments", myPayments);
        }
       

    }
}
