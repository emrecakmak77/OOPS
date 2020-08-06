using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IDisabilitySituationService : IServiceBase
    {
        List<DisabilitySituationDTO> getAll();
        DisabilitySituationDTO getDisabilitySituation(int Id);
        DisabilitySituationDTO newDisabilitySituation(DisabilitySituationDTO DisabilitySituation);
        DisabilitySituationDTO updateDisabilitySituation(DisabilitySituationDTO DisabilitySituation);
        bool deleteDisabilitySituationDTO(int DisabilitySituationId);
    }
}
