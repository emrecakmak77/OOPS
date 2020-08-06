using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class AccessTypesViewComponent : ViewComponent
    {
        private readonly IAccessTypeService accessTypeService;
        public AccessTypesViewComponent(IAccessTypeService _accessTypeService)
        {
            accessTypeService = _accessTypeService;
        }

        public IViewComponentResult Invoke()
        {
            return View(accessTypeService.getAll());
        }

    }
}
