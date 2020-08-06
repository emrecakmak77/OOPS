using OOPS.BLL.Abstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.CompanyModels;
using OOPS.Model.EmployeeModel;
using OOPS.Model.ProjectBaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate
{
    public class PermitService : IPermitService
    {
        private readonly IUnitofWork uow;
        public PermitService(IUnitofWork _uow)
        {
            uow = _uow;
        }
        public bool deletePermit(int PermitId)
        {
            try
            {
                var getPermit = uow.GetRepository<EmployeePermit>().Get(z => z.Id == PermitId);
                uow.GetRepository<EmployeePermit>().Delete(getPermit);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public PermitDTO getPermit(int Id)
        {
            var getPermit = uow.GetRepository<Permit>().GetAll().Where(x => x.Id == Id).FirstOrDefault();
            return MapperFactory.CurrentMapper.Map<PermitDTO>(getPermit);
        }

        public List<PermitDTO> getEmployeePermits(int employeeId)
        {
            var emp = uow.GetRepository<EmployeePermit>().GetAll().Where(z => z.EmployeeId == employeeId).Select(x => x.Permit).ToList();
            return MapperFactory.CurrentMapper.Map<List<PermitDTO>>(emp);
        }

        public List<PermitDTO> getAllEmployeePermitsByCompanyId(int companyId)
        {
            var emp = uow.GetRepository<EmployeePermit>().Get(x => x.Employee.CompanyID == companyId, x => x.Permit.PermitType).Select(x => x.Permit).OrderByDescending(x => x.Id).ToList();
            return MapperFactory.CurrentMapper.Map<List<PermitDTO>>(emp);
        }

        public List<PermitDTO> getAllEmployeePermits()
        {
            //var emp = uow.GetRepository<Employee>().Get(z => z.CompanyID == companyId);
            //var permits = emp.EmployeePermits.Where(z => z.Permit.StartDate)

            var emp = uow.GetRepository<EmployeePermit>().Get(null, x => x.Permit.PermitType).Select(x => x.Permit).OrderByDescending(x => x.Id).ToList();
            return MapperFactory.CurrentMapper.Map<List<PermitDTO>>(emp);
        }

        public List<EmployeePermitDTO> getEmployeePermits()
        {
            //var emp = uow.GetRepository<Employee>().Get(z => z.CompanyID == companyId);
            //var permits = emp.EmployeePermits.Where(z => z.Permit.StartDate)

            var emp = uow.GetRepository<EmployeePermit>().Get(null, x => x.Employee).ToList();
            return MapperFactory.CurrentMapper.Map<List<EmployeePermitDTO>>(emp);
        }

        public PermitDTO newPermit(PermitDTO Permit)
        {
            var addedPermit = MapperFactory.CurrentMapper.Map<Permit>(Permit);
            uow.GetRepository<Permit>().Add(addedPermit);
            uow.SaveChanges();
            var addedEmployeePermit = new EmployeePermit()
            {
                EmployeeId = Permit.EmployeeId,
                PermitId = addedPermit.Id
            };
            uow.GetRepository<EmployeePermit>().Add(addedEmployeePermit);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<PermitDTO>(addedPermit);
        }

        public PermitDTO updatePermit(PermitDTO Permit)
        {
            var selectedEmp = uow.GetRepository<EmployeePermit>().Get(z => z.Id == Permit.Id);
            selectedEmp = MapperFactory.CurrentMapper.Map(Permit, selectedEmp);
            uow.GetRepository<EmployeePermit>().Update(selectedEmp);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<PermitDTO>(selectedEmp);
        }
    }
}
