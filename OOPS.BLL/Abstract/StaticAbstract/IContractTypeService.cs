using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IContractTypeService : IServiceBase
    {
        List<ContractTypeDTO> getAll();
        ContractTypeDTO getContractType(int Id);
        ContractTypeDTO newContractType(ContractTypeDTO ContractType);
        ContractTypeDTO updateContractType(ContractTypeDTO ContractType);
        bool deleteContractTypeDTO(int ContractTypeId);
    }
}
