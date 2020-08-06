using OOPS.Core.Business;
using OOPS.DTO.Static;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IVisaDocumentRequestsService : IServiceBase
    {
        List<VisaDocumentRequestDTO> getAllEmployeeVisaDocumentRequests();
        VisaDocumentRequestDTO getVisaDocumentRequest(int Id);
        List<VisaDocumentRequestDTO> getEmployeeVisaDocumentRequests(int employeeId);
        VisaDocumentRequestDTO newVisaDocumentRequest(VisaDocumentRequestDTO VisaDocumentRequest);
        VisaDocumentRequestDTO updateVisaDocumentRequest(VisaDocumentRequestDTO VisaDocumentRequest);
    }
}
