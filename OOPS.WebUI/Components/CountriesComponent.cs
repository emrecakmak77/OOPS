using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class CountriesViewComponent : ViewComponent
    {
        private readonly ICountryService countryService;
        public CountriesViewComponent(ICountryService _countryService)
        {
            countryService = _countryService;
        }

        public IViewComponentResult Invoke()
        {
            return View(countryService.getAll());
        }
    }
}
