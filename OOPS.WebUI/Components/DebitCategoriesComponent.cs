using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class DebitCategoriesViewComponent : ViewComponent
    {
        private readonly IDebitCategoryService debitCategoryService;

        public DebitCategoriesViewComponent(IDebitCategoryService _debitCategoryService)
        {
            debitCategoryService = _debitCategoryService;
        }

        public IViewComponentResult Invoke()
        {
            return View(debitCategoryService.getAll());
        }
    }
}
