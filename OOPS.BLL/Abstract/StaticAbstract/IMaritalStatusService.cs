using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IMaritalStatusService : IServiceBase
    {
        List<MaritalStatusDTO> getAll();
        MaritalStatusDTO getMaritalStatus(int Id);
        MaritalStatusDTO newMaritalStatus(MaritalStatusDTO MaritalStatus);
        MaritalStatusDTO updateMaritalStatus(MaritalStatusDTO MaritalStatus);
        bool deleteMaritalStatusDTO(int MaritalStatusId);
    }
}
