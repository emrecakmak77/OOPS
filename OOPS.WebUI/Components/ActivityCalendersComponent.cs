using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class ActivityCalendersViewComponent : ViewComponent
    {
        private readonly IActivityCalenderService  activityCalenderService;

        public ActivityCalendersViewComponent(IActivityCalenderService _activityCalenderService)
        {
            activityCalenderService = _activityCalenderService;
        }

        public IViewComponentResult Invoke()
        {
            return View(activityCalenderService.getAll());
        }
    }
}
