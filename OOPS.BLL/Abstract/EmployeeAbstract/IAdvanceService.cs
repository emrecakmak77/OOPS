using OOPS.Core.Business;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.Employee
{
    public interface IAdvanceService : IServiceBase
    {
        List<AdvanceDTO> getAll();
        AdvanceDTO getAdvance(int Id);
        AdvanceDTO newAdvance(AdvanceDTO advance);
        AdvanceDTO updateAdvance(AdvanceDTO advance);
        bool deleteAdvance(int advanceId);
    }
}
