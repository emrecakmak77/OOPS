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
    public class EducationService : IEducationService
    {
        private readonly IUnitofWork uow;
        public EducationService(IUnitofWork _uow)
        {
            uow = _uow;
        }
        public bool deleteEducation(int educationId)
        {
            try
            {
                var getEducation = uow.GetRepository<Education>().Get(z => z.Id == educationId);
                uow.GetRepository<Education>().Delete(getEducation);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public EducationDTO getEducation(int Id)
        {
            var getEducation = uow.GetRepository<Education>().GetAll().Where(x => x.Id == Id).FirstOrDefault();
            return MapperFactory.CurrentMapper.Map<EducationDTO>(getEducation);
        }

        public List<EducationDTO> getEducations(int educationId)
        {
            var getEducationList = uow.GetRepository<Education>().Get(null, null, null).ToList();
            return MapperFactory.CurrentMapper.Map<List<EducationDTO>>(getEducationList);
        }

        public EducationDTO newEducation(EducationDTO Education)
        {
            var adedEducation = MapperFactory.CurrentMapper.Map<Education>(Education);
            adedEducation = uow.GetRepository<Education>().Add(adedEducation);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<EducationDTO>(adedEducation);

        }

        public EducationDTO updateEducation(EducationDTO Education)
        {
            var selectedEducation = uow.GetRepository<Education>().Get(z => z.Id == Education.EducationsTypeID);
            selectedEducation = MapperFactory.CurrentMapper.Map(Education, selectedEducation);
            uow.GetRepository<Education>().Update(selectedEducation);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<EducationDTO>(selectedEducation);
        }
    }
}
