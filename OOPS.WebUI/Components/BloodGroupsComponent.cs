using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class BloodGroupsViewComponent : ViewComponent
    {
        private readonly IBloodGroupService bloodGroupService;

        public BloodGroupsViewComponent(IBloodGroupService _bloodGroupService)
        {
            bloodGroupService = _bloodGroupService;
        }

        public IViewComponentResult Invoke()
        {
            return View(bloodGroupService.getAll());
        }
    }
}
