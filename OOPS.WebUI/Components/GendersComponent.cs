using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class GendersViewComponent : ViewComponent
    {
        private readonly IGenderService genderService;
        public GendersViewComponent(IGenderService _genderService)
        {
            genderService = _genderService;
        }

        public IViewComponentResult Invoke()
        {
            return View(genderService.getAll());
        }
    }
}
