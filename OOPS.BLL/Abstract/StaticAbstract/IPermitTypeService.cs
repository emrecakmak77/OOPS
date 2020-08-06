using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IPermitTypeService : IServiceBase
    {
        List<PermitTypeDTO> getAll();
        PermitTypeDTO getPermitType(int Id);
        PermitTypeDTO newPermitType(PermitTypeDTO PermitType);
        PermitTypeDTO updatePermitType(PermitTypeDTO PermitType);
        bool deletePermitTypeDTO(int PermitTypeId);
    }
}
