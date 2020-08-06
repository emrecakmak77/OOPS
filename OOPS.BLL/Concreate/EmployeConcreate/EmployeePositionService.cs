using OOPS.BLL.Abstract.EmployeeAbstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Employee;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate.EmployeConcreate
{
    public class EmployeePositionService : IEmployeePositionService
    {
        private readonly IUnitofWork uow;
        public EmployeePositionService(IUnitofWork _uow)
        {
            uow = _uow;
        }
        public List<EmployeePositionDTO> getEmployeePosition(int Id)
        {
            var getEmployeePosition = uow.GetRepository<EmployeePosition>().GetAll().Where(z=>z.EmployeeId == Id).ToList();
            return MapperFactory.CurrentMapper.Map<List<EmployeePositionDTO>>(getEmployeePosition);
        }

        public EmployeePositionDTO newEmployeePosition(EmployeePositionDTO employeePosition)
        {
            var added = MapperFactory.CurrentMapper.Map<EmployeePosition>(employeePosition);
            added = uow.GetRepository<EmployeePosition>().Add(added);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<EmployeePositionDTO>(added);
        }

        public EmployeePositionDTO updateEmployeePosition(EmployeePositionDTO employeePosition)
        {
            var selectedEmployeePosition = uow.GetRepository<EmployeePosition>().Get(z => z.Id == employeePosition.Id);
            selectedEmployeePosition = MapperFactory.CurrentMapper.Map(employeePosition, selectedEmployeePosition);
            uow.GetRepository<EmployeePosition>().Update(selectedEmployeePosition);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<EmployeePositionDTO>(selectedEmployeePosition);
        }
    }
}
