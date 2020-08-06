using OOPS.BLL.Abstract;
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
    public class EmployeeSalaryService : ISalaryService
    {
        private readonly IUnitofWork uow;
        public EmployeeSalaryService(IUnitofWork _uow)
        {
            uow = _uow;
        }

        public List<EmployeeSalaryDTO> getAllEmployeeSalaries()
        {
            var getEmployeeSalary = uow.GetRepository<EmployeeSalary>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<EmployeeSalaryDTO>>(getEmployeeSalary);
        }

        public EmployeeSalaryDTO getSalary(int Id)
        {
            var getEmployeeSalary = uow.GetRepository<EmployeeSalary>().GetAll().Where(z=>z.EmployeeId == Id).FirstOrDefault();
            return MapperFactory.CurrentMapper.Map<EmployeeSalaryDTO>(getEmployeeSalary);
        }

        public EmployeeSalaryDTO newSalary(EmployeeSalaryDTO employeeSalary)
        {
            var added = MapperFactory.CurrentMapper.Map<EmployeeSalary>(employeeSalary);
            added = uow.GetRepository<EmployeeSalary>().Add(added);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<EmployeeSalaryDTO>(added);
        }

        public EmployeeSalaryDTO updateSalary(EmployeeSalaryDTO employeeSalary)
        {
            var selectedEmployeeSalary = uow.GetRepository<EmployeeSalary>().Get(z => z.Id == employeeSalary.Id);
            selectedEmployeeSalary = MapperFactory.CurrentMapper.Map(employeeSalary, selectedEmployeeSalary);
            uow.GetRepository<EmployeeSalary>().Update(selectedEmployeeSalary);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<EmployeeSalaryDTO>(selectedEmployeeSalary);
        }

    }
}
