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
    public class EducationLevelService : IEducationLevelService
    {
        private readonly IUnitofWork uow;
        public EducationLevelService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteEducationLevelDTO(int EducationLevelId)
        {
            try
            {
                var getEducationLevel = uow.GetRepository<EducationLevel>().Get(z => z.Id == EducationLevelId);
                uow.GetRepository<EducationLevel>().Delete(getEducationLevel);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<EducationLevelDTO> getAll()
        {
            var getEducationLevelList = uow.GetRepository<EducationLevel>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<EducationLevelDTO>>(getEducationLevelList);
        }

        public EducationLevelDTO getEducationLevel(int Id)
        {
            var getEducationLevel = uow.GetRepository<EducationLevel>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<EducationLevelDTO>(getEducationLevel);
        }

        public EducationLevelDTO newEducationLevel(EducationLevelDTO EducationLevel)
        {
            if (!uow.GetRepository<EducationLevel>().GetAll().Any(z => z.Id == EducationLevel.Id))
            {
                var adedEducationLevel = MapperFactory.CurrentMapper.Map<EducationLevel>(EducationLevel);
                adedEducationLevel = uow.GetRepository<EducationLevel>().Add(adedEducationLevel);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<EducationLevelDTO>(adedEducationLevel);
            }
            else
            {
                return null;
            }
        }

        public EducationLevelDTO updateEducationLevel(EducationLevelDTO EducationLevel)
        {
            var selectedEducationLevel = uow.GetRepository<EducationLevel>().Get(z => z.Id == EducationLevel.Id);
            selectedEducationLevel = MapperFactory.CurrentMapper.Map(EducationLevel, selectedEducationLevel);
            uow.GetRepository<EducationLevel>().Update(selectedEducationLevel);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<EducationLevelDTO>(selectedEducationLevel);
        }
    }
}
