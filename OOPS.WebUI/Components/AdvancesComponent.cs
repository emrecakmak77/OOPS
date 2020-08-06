using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class AdvancesViewComponent : ViewComponent
    {
        private readonly IAdvanceService advanceService;
        public AdvancesViewComponent(IAdvanceService _advanceService)
        {
            advanceService = _advanceService;
        }

        public IViewComponentResult Invoke()
        {
            return View(advanceService.getAll());
        }
    }
}
