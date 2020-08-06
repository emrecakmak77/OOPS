using OOPS.Core.Business;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract
{
    public interface IPositionService : IServiceBase
    {
        PositionDTO getPositions(int Id);
        List<PositionDTO> getEmployeePosition(int positionId);
        PositionDTO newPosition(PositionDTO Position);
        PositionDTO updatePosition(PositionDTO Position);
    }
}
