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
    public class EmployeDetailService : IEmployeeDetailService
    {
        private readonly IUnitofWork uow;
        public EmployeDetailService(IUnitofWork _uow)
        {
            uow = _uow;
        }
        public bool deleteEmployeeDetail(int employeeDetailId)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeDetailDTO> getAll()
        {
            throw new NotImplementedException();
        }

        public EmployeeDetailDTO getEmployeeDetail(int Id)
        {
            var getEmployeeDetail = uow.GetRepository<Model.EmployeeModel.EmployeeDetail>().Get(z => z.EmployeeID == Id);
            return MapperFactory.CurrentMapper.Map<EmployeeDetailDTO>(getEmployeeDetail);
        }

        public EmployeeDetailDTO newEmployeeDetail(EmployeeDetailDTO employeeDetail)
        {
            var added = MapperFactory.CurrentMapper.Map<EmployeeDetail>(employeeDetail);
            added = uow.GetRepository<EmployeeDetail>().Add(added);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<EmployeeDetailDTO>(added);
        }

        public EmployeeDetailDTO updateEmployeeDetail(EmployeeDetailDTO employeeDetail)
        {
            var selectedEmployeeDetail = uow.GetRepository<EmployeeDetail>().Get(z => z.Id == employeeDetail.Id);
            selectedEmployeeDetail = MapperFactory.CurrentMapper.Map(employeeDetail, selectedEmployeeDetail);
            uow.GetRepository<EmployeeDetail>().Update(selectedEmployeeDetail);
            selectedEmployeeDetail.EmployeeID = employeeDetail.EmployeeID;
            selectedEmployeeDetail.BloodGroupID = employeeDetail.BloodGroupID;
            selectedEmployeeDetail.DisabilitySituationID = employeeDetail.DisabilitySituationID;
            selectedEmployeeDetail.EducationLevelID = employeeDetail.EducationLevelID;
            selectedEmployeeDetail.EducationStatusID = employeeDetail.EducationStatusID;
            selectedEmployeeDetail.GenderID = employeeDetail.GenderID;
            selectedEmployeeDetail.MaritalStatusID = employeeDetail.MaritalStatusID;
            uow.GetRepository<EmployeeDetail>().Update(selectedEmployeeDetail);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<EmployeeDetailDTO>(selectedEmployeeDetail);
        }
    }
}
