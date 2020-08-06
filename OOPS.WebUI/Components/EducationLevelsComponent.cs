using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class EducationLevelsViewComponent : ViewComponent
    {
        private readonly IEducationLevelService educationLevelService;
        public EducationLevelsViewComponent(IEducationLevelService _educationLevelService)
        {
            educationLevelService = _educationLevelService;
        }

        public IViewComponentResult Invoke()
        {
            return View(educationLevelService.getAll());
        }
    }
}
