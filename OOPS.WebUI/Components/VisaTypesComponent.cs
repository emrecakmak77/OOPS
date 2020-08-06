using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class VisaTypesViewComponent : ViewComponent
    {
        private readonly IVisaTypeService visaTypeService;
        public VisaTypesViewComponent(IVisaTypeService _visaTypeService)
        {
            visaTypeService = _visaTypeService;
        }

        public IViewComponentResult Invoke()
        {
            return View(visaTypeService.getAll());
        }
    }
}
