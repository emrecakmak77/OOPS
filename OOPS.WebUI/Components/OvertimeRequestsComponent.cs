using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class OvertimeRequestsViewComponent : ViewComponent
    {
        private readonly IOvertimeRequestsService  overtimeRequestsService;

        public OvertimeRequestsViewComponent(IOvertimeRequestsService _overtimeRequestsService)
        {
            overtimeRequestsService = _overtimeRequestsService;
        }

        public IViewComponentResult Invoke()
        {
            //return View(overtimeRequestsService.getAll());
            return View();
        }
    }
}
