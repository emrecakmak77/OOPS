using OOPS.BLL.Abstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Employee;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate
{
    public class PositionService : IPositionService
    {
        private readonly IUnitofWork uow;
        public PositionService(IUnitofWork _uow)
        {
            uow = _uow;
        }

        public List<PositionDTO> getEmployeePosition(int positionId)
        {
            throw new NotImplementedException();
        }

        public PositionDTO getPositions(int Id)
        {
            var emp = uow.GetRepository<Position>().Get(z => z.EmployeeId == Id);
            return MapperFactory.CurrentMapper.Map<PositionDTO>(emp);
        }

        public PositionDTO newPosition(PositionDTO Position)
        {
            var addedPosition = MapperFactory.CurrentMapper.Map<Position>(Position);
            uow.GetRepository<Position>().Add(addedPosition);
            uow.SaveChanges();
            var addedEmployeePosition = new EmployeePosition()
            {
                EmployeeId = Position.EmployeeId,
                PositionId = addedPosition.Id
            };
            uow.GetRepository<EmployeePosition>().Add(addedEmployeePosition);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<PositionDTO>(addedPosition);
        }

        public PositionDTO updatePosition(PositionDTO Position)
        {
            var selectedPosition = uow.GetRepository<Position>().Get(z => z.Id == Position.Id);
            selectedPosition = MapperFactory.CurrentMapper.Map(Position, selectedPosition);
            uow.GetRepository<Position>().Update(selectedPosition);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<PositionDTO>(selectedPosition);
        }
    }
}
