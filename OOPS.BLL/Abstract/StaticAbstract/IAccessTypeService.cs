using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IAccessTypeService : IServiceBase
    {
        List<AccessTypeDTO> getAll();
        AccessTypeDTO getAccessType(int Id);
        AccessTypeDTO newAccessType(AccessTypeDTO AccessType);
        AccessTypeDTO updateAccessType(AccessTypeDTO AccessType);
        bool deleteAccessTypeDTO(int AccessTypeId);
    }
}
