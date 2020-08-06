using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Employee;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace OOPS.BLL.Concreate.StaticConcreate
{
    public class OvertimeService : IOvertimeService
    {
        private readonly IUnitofWork uow;

        public OvertimeService(IUnitofWork _uow)
        {
            uow = _uow;
        }

        public List<OvertimeDTO> getAllEmployeeOvertimes()
        {
            var emp = uow.GetRepository<EmployeeOverTime>().Get(null, x => x.Overtime).Select(x => x.Overtime).OrderByDescending(x => x.Id).ToList();
            return MapperFactory.CurrentMapper.Map<List<OvertimeDTO>>(emp);
        }

        public List<OvertimeDTO> getAllEmployeeOvertimesByCompanyId(int companyId)
        {
            var emp = uow.GetRepository<EmployeeOverTime>().Get(x => x.Employee.CompanyID == companyId, x => x.Overtime).Select(x => x.Overtime).OrderByDescending(x => x.Id).ToList();
            return MapperFactory.CurrentMapper.Map<List<OvertimeDTO>>(emp);

        }

        public List<OvertimeDTO> getEmployeeOvertimes(int emloyeeId)
        {
            var emp = uow.GetRepository<EmployeeOverTime>().GetAll().Where(x => x.EmployeeId == emloyeeId).Select(x => x.Overtime).ToList();
            return MapperFactory.CurrentMapper.Map<List<OvertimeDTO>>(emp);
        }

        public OvertimeDTO getOvertime(int Id)
        {
            var getOvertime = uow.GetRepository<Overtime>().GetAll().Where(x => x.Id == Id).FirstOrDefault();
            return MapperFactory.CurrentMapper.Map<OvertimeDTO>(getOvertime);
        }

        public OvertimeDTO newOvertime(OvertimeDTO Overtime)
        {
            var addedOvertime = MapperFactory.CurrentMapper.Map<Overtime>(Overtime);
            uow.GetRepository<Overtime>().Add(addedOvertime);
            uow.SaveChanges();
            var addedEmployeeOvertime = new EmployeeOverTime()
            {
                EmployeeId = Overtime.EmployeeId,
                OvertimeId = addedOvertime.Id
            };
            uow.GetRepository<EmployeeOverTime>().Add(addedEmployeeOvertime);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<OvertimeDTO>(addedOvertime);
        }

        public OvertimeDTO updateOvertime(OvertimeDTO Overtime)
        {
            var selectedEmp = uow.GetRepository<EmployeeOverTime>().Get(x => x.Id == Overtime.Id);
            selectedEmp = MapperFactory.CurrentMapper.Map(Overtime, selectedEmp);
            uow.GetRepository<EmployeeOverTime>().Update(selectedEmp);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<OvertimeDTO>(selectedEmp);
        }
    }
}
