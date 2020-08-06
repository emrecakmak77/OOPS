using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class DistrictsViewComponent : ViewComponent
    {
        private readonly IDistrictService districtService;
        public DistrictsViewComponent(IDistrictService _districtService)
        {
            districtService = _districtService;
        }

        public IViewComponentResult Invoke()
        {
            return View(districtService.getAll());
        }
    }
}
