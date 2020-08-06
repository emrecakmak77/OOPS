using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class MaritalStatusesViewComponent : ViewComponent
    {
        private readonly IMaritalStatusService maritalStatusService;
        public MaritalStatusesViewComponent(IMaritalStatusService _maritalStatusService)
        {
            maritalStatusService = _maritalStatusService;
        }

        public IViewComponentResult Invoke()
        {
            return View(maritalStatusService.getAll());
        }
    }
}
