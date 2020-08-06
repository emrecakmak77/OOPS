using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class EmploymentTypesViewComponent : ViewComponent
    {
        private readonly IEmploymentTypeService employmentTypeService;

        public EmploymentTypesViewComponent(IEmploymentTypeService _employmentTypeService)
        {
            employmentTypeService = _employmentTypeService;
        }

        public IViewComponentResult Invoke()
        {
            return View(employmentTypeService.getAll());
        }
    }
}
