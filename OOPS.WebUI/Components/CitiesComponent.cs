using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class CitiesViewComponent : ViewComponent
    {
        private readonly ICityService cityService;
        public CitiesViewComponent(ICityService _cityService)
        {
            cityService = _cityService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cityService.getAll());
        }
    }
}
