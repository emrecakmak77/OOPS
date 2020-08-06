using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.EmployeeAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class SystemEducationsViewComponent : ViewComponent
    {
        private readonly ISystemEducationService systemEducationService;
        public SystemEducationsViewComponent(ISystemEducationService _systemEducationService)
        {
            systemEducationService = _systemEducationService;
        }

        public IViewComponentResult Invoke(int companyId)
        {
            return View(systemEducationService.getAllSystemEducations(companyId));
        }
    }
}
