using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.EmployeeAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class PaymentsViewComponent : ViewComponent
    {
        private IPaymentsService paymentsService;
        public PaymentsViewComponent(IPaymentsService _paymentsService)
        {
            paymentsService = _paymentsService;
        }

        public IViewComponentResult Invoke(int companyId)
        {
            return View(paymentsService.getAllEmployeePaymentsByCompanyId(companyId));
        }

    }
}
