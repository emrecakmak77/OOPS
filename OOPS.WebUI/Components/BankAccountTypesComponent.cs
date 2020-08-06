using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class BankAccountTypesViewComponent : ViewComponent
    {
        private readonly IBankAccountTypeService bankAccountTypeService;
        public BankAccountTypesViewComponent(IBankAccountTypeService _bankAccountTypeService)
        {
            bankAccountTypeService = _bankAccountTypeService;
        }

        public IViewComponentResult Invoke()
        {
            return View(bankAccountTypeService.getAll());
        }
    }
}