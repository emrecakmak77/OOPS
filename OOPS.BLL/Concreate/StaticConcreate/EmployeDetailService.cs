using OOPS.BLL.Abstract.EmployeeAbstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Employee;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate.StaticConcreate
{
   public class EmployeDetailService : IEmployeeDetailService
    {
        private readonly IUnitofWork uow;
        public EmployeDetailService(IUnitofWork _uow)
        {
            uow = _uow;
        }
        

        public List<EmployeeDetailDTO> getAll()
        {
            throw new NotImplementedException();
        }

        public List<EmployeeDetailDTO>  getEmployeeDetail(int companyId)
        {
            var emp = uow.GetRepository<Employee>().Get(z => z.CompanyID == companyId);
            var birtdate = emp.EmployeeDetail.BirthDate.ToList();
            return MapperFactory.CurrentMapper.Map<List<EmployeeDetailDTO>>(birtdate);
        }

      
    }

        
    
}
