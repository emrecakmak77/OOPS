using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class PermitTypesViewComponent : ViewComponent
    {
        private readonly IPermitTypeService permitTypeService;
        public PermitTypesViewComponent(IPermitTypeService _permitTypeService)
        {
            permitTypeService = _permitTypeService;
        }

        public IViewComponentResult Invoke()
        {
            return View(permitTypeService.getAll());
        }
    }
}
