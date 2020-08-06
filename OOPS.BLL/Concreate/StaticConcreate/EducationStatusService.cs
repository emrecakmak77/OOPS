using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Static;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate.StaticConcreate
{
    public class EducationStatusService : IEducationStatusService
    {
        private readonly IUnitofWork uow;
        public EducationStatusService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteEducationStatusDTO(int EducationStatusId)
        {
            try
            {
                var getEducationStatus = uow.GetRepository<EducationStatus>().Get(z => z.Id == EducationStatusId);
                uow.GetRepository<EducationStatus>().Delete(getEducationStatus);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<EducationStatusDTO> getAll()
        {
            var getEducationStatusLevelList = uow.GetRepository<EducationStatus>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<EducationStatusDTO>>(getEducationStatusLevelList);
        }

        public EducationStatusDTO getEducationStatus(int Id)
        {
            var getEducationStatus = uow.GetRepository<EducationStatus>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<EducationStatusDTO>(getEducationStatus);
        }

        public EducationStatusDTO newEducationStatus(EducationStatusDTO EducationStatus)
        {
            if (!uow.GetRepository<EducationStatus>().GetAll().Any(z => z.Id == EducationStatus.Id))
            {
                var adedEducationStatus = MapperFactory.CurrentMapper.Map<EducationStatus>(EducationStatus);
                adedEducationStatus = uow.GetRepository<EducationStatus>().Add(adedEducationStatus);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<EducationStatusDTO>(adedEducationStatus);
            }
            else
            {
                return null;
            }
        }

        public EducationStatusDTO updateEducationStatus(EducationStatusDTO EducationStatus)
        {
            var selectedEducationStatus = uow.GetRepository<EducationStatus>().Get(z => z.Id == EducationStatus.Id);
            selectedEducationStatus = MapperFactory.CurrentMapper.Map(EducationStatus, selectedEducationStatus);
            uow.GetRepository<EducationStatus>().Update(selectedEducationStatus);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<EducationStatusDTO>(selectedEducationStatus);
        }
    }
}
