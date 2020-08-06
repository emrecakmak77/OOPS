using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class OvertimesViewComponent : ViewComponent
    {
        private readonly IOvertimeService overtimeService;

        public OvertimesViewComponent(IOvertimeService _overtimeService)
        {
            overtimeService = _overtimeService;
        }

        public IViewComponentResult Invoke(int companyId)
        {
            return View(overtimeService.getAllEmployeeOvertimesByCompanyId(companyId));
        }
    }
}
