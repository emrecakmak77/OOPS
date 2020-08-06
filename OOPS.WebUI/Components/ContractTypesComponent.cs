using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class ContractTypesViewComponent : ViewComponent
    {
        private readonly IContractTypeService contractTypesService;
        public ContractTypesViewComponent(IContractTypeService _contractTypesService)
        {
            contractTypesService = _contractTypesService;
        }

        public IViewComponentResult Invoke()
        {
            return View(contractTypesService.getAll());
        }
    }
}
