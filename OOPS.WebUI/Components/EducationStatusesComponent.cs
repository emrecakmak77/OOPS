using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class EducationStatusesViewComponent : ViewComponent
    {
        private readonly IEducationStatusService educationStatusService;
        public EducationStatusesViewComponent(IEducationStatusService _educationStatusService)
        {
            educationStatusService = _educationStatusService;
        }

        public IViewComponentResult Invoke()
        {
            return View(educationStatusService.getAll());
        }
    }
}
