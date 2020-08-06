using OOPS.BLL.Abstract.EmployeeAbstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Employee;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Concreate.EmployeConcreate
{
   public class EmployeeOtherInfoService : IEmployeeOtherInfoService
    {
        private readonly IUnitofWork uow;
        public EmployeeOtherInfoService(IUnitofWork uow)
        {
            this.uow = uow;
        }

        public bool deleteEmployeeOtherInfo(int employeeOtherInfoId)
        {
            try
            {
                var getEmployeeOtherInfo = uow.GetRepository<EmployeeOtherInfo>().Get(z => z.Id == employeeOtherInfoId);
                uow.GetRepository<EmployeeOtherInfo>().Delete(getEmployeeOtherInfo);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public EmployeeOtherInfoDTO getEmployeeOtherInfo(int Id)
        {
            var getEmployeeOtherInfo = uow.GetRepository<EmployeeOtherInfo>().Get(z => z.EmployeeID == Id);
            return MapperFactory.CurrentMapper.Map<EmployeeOtherInfoDTO>(getEmployeeOtherInfo);
        }

        public EmployeeOtherInfoDTO newEmployeeOtherInfo(EmployeeOtherInfoDTO employeeOtherInfo)
        {
            var adedEmployeeOtherInfo = MapperFactory.CurrentMapper.Map<EmployeeOtherInfo>(employeeOtherInfo);
            adedEmployeeOtherInfo = uow.GetRepository<EmployeeOtherInfo>().Add(adedEmployeeOtherInfo);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<EmployeeOtherInfoDTO>(adedEmployeeOtherInfo);
        }

        public EmployeeOtherInfoDTO updateEmployeeOtherInfo(EmployeeOtherInfoDTO employeeOtherInfo)
        {
            var selectedEmployeeOtherInfo = uow.GetRepository<EmployeeOtherInfo>().Get(z => z.Id == employeeOtherInfo.Id);
            selectedEmployeeOtherInfo = MapperFactory.CurrentMapper.Map(employeeOtherInfo, selectedEmployeeOtherInfo);
            uow.GetRepository<EmployeeOtherInfo>().Update(selectedEmployeeOtherInfo);
            selectedEmployeeOtherInfo.CityId = employeeOtherInfo.CityId;
            selectedEmployeeOtherInfo.CountryId = employeeOtherInfo.CountryId;
            selectedEmployeeOtherInfo.DistrictId = employeeOtherInfo.DistrictId;
            selectedEmployeeOtherInfo.EmployeeID = employeeOtherInfo.EmployeeID;
            selectedEmployeeOtherInfo.BankAccountTypeId = employeeOtherInfo.BankAccountTypeId;
            uow.GetRepository<EmployeeOtherInfo>().Update(selectedEmployeeOtherInfo);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<EmployeeOtherInfoDTO>(selectedEmployeeOtherInfo);
        }
    }
}
