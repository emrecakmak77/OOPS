using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class DisabilitySituationsViewComponent : ViewComponent
    {
        private readonly IDisabilitySituationService disabilitySituationsService;
        public DisabilitySituationsViewComponent(IDisabilitySituationService _disabilitySituationsService)
        {
            disabilitySituationsService = _disabilitySituationsService;
        }

        public IViewComponentResult Invoke()
        {
            return View(disabilitySituationsService.getAll());
        }
    }
}
