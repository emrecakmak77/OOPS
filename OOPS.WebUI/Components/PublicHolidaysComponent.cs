using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class PublicHolidaysViewComponent : ViewComponent
    {
        
            private readonly IPublicHolidaysService holidayService;

            public PublicHolidaysViewComponent(IPublicHolidaysService _holidayService)
            {
            holidayService = _holidayService;
            }

            public IViewComponentResult Invoke()
            {
                return View(holidayService.getAll());
            }
        
    }
}
