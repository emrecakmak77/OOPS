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
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitofWork uow;
        public EmployeeService(IUnitofWork _uow)
        {
            uow = _uow;
        }
        public bool deleteEmployee(int employeeId)
        {
            try
            {
                var getEmployee = uow.GetRepository<Employee>().Get(z => z.Id == employeeId);
                uow.GetRepository<Employee>().Delete(getEmployee);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<EmployeeDTO> getCompanyEmployees(int companyId)
        {
            var companyEmployee = uow.GetRepository<Employee>().GetAll().Where(a => a.Company.Id == companyId);
            return MapperFactory.CurrentMapper.Map<List<EmployeeDTO>>(companyEmployee);
        }

        public EmployeeDTO getEmployee(int Id)
        {
            var getEmployee = uow.GetRepository<Employee>()
        .GetIncludes(a => a.Id == Id,
                     b => b.EmployeePermits,
                     c => c.EmployeePositions,
                     d => d.Company,
                     e => e.EmployeeVisas,
                     f => f.EmployeeOverTimes
                     g=>g.EmployeePayments
                     );
            return MapperFactory.CurrentMapper.Map<EmployeeDTO>(getEmployee);
            //var emp = uow.GetRepository<Employee>().Get(z=>z.Id==Id);
            //return MapperFactory.CurrentMapper.Map<EmployeeDTO>(emp);
        }

        public EmployeeDTO getEmployeeInfo(int Id)
        {
            var emp = uow.GetRepository<Employee>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<EmployeeDTO>(emp);
        }

        public EmployeeDTO getEmployeeUser(int Id)
        {
            var emp = uow.GetRepository<Employee>().Get(z => z.UserID == Id);
            return MapperFactory.CurrentMapper.Map<EmployeeDTO>(emp);
        }

        public EmployeeDTO newEmployee(EmployeeDTO employee)
        {
            var added = MapperFactory.CurrentMapper.Map<Employee>(employee);
            added = uow.GetRepository<Employee>().Add(added);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<EmployeeDTO>(added);
        }

        public EmployeeDTO updateEmployee(EmployeeDTO employee)
        {
            var selectedEmp = uow.GetRepository<Employee>().Get(z => z.Id == employee.Id);
            selectedEmp = MapperFactory.CurrentMapper.Map(employee, selectedEmp);

            uow.GetRepository<Employee>().Update(selectedEmp);
            selectedEmp.CompanyID = employee.CompanyID;
            uow.GetRepository<Employee>().Update(selectedEmp);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<EmployeeDTO>(selectedEmp);
        }
    }
}
