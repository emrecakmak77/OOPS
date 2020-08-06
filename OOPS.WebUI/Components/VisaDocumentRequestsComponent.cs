using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class VisaDocumentRequestsViewComponent : ViewComponent
    {
        private readonly IVisaDocumentRequestsService  visaDocumentRequestsService;

        public VisaDocumentRequestsViewComponent(IVisaDocumentRequestsService _visaDocumentRequestsService)
        {
            visaDocumentRequestsService = _visaDocumentRequestsService;
        }

        public IViewComponentResult Invoke()
        {
            return View(visaDocumentRequestsService.getAllEmployeeVisaDocumentRequests());
        }
    }
}
