using OOPS.BLL.Abstract.EmployeeAbstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Employee;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate.EmployeeConcreate
{
    public class SystemEducationService : ISystemEducationService
    {
        private readonly IUnitofWork uow;
        public SystemEducationService(IUnitofWork uow)
        {
            this.uow = uow;
        }

        public bool deleteSystemEducation(int systemEducationId)
        {
            try
            {
                var getSystemEducation = uow.GetRepository<SystemEducation>().Get(z => z.Id == systemEducationId);
                uow.GetRepository<SystemEducation>().Delete(getSystemEducation);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<SystemEducationDTO> getAll()
        {
            var getSystemEducationList = uow.GetRepository<SystemEducation>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<SystemEducationDTO>>(getSystemEducationList);
        }

        public List<SystemEducationDTO> getAllSystemEducations(int Id)
        {
            var systemEducations = uow.GetRepository<SystemEducation>().GetAll().Where(z => z.CompanyID == Id).ToList();
            return MapperFactory.CurrentMapper.Map<List<SystemEducationDTO>>(systemEducations);
        }

        public SystemEducationDTO getSystemEducation(int Id)
        {
            var getSystemEducation = uow.GetRepository<SystemEducation>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<SystemEducationDTO>(getSystemEducation);
        }

        public SystemEducationDTO newSystemEducation(SystemEducationDTO SystemEducation)
        {
            var adedSystemEducation = MapperFactory.CurrentMapper.Map<SystemEducation>(SystemEducation);
            adedSystemEducation = uow.GetRepository<SystemEducation>().Add(adedSystemEducation);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<SystemEducationDTO>(adedSystemEducation);
        }

        public SystemEducationDTO updateSystemEducation(SystemEducationDTO SystemEducation)
        {
            var selectedSystemEducation = uow.GetRepository<SystemEducation>().Get(z => z.Id == SystemEducation.Id);
            selectedSystemEducation = MapperFactory.CurrentMapper.Map(SystemEducation, selectedSystemEducation);
            uow.GetRepository<SystemEducation>().Update(selectedSystemEducation);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<SystemEducationDTO>(selectedSystemEducation);
        }



    }
}
