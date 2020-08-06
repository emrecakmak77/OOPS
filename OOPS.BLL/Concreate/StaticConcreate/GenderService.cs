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
    public class GenderService : IGenderService
    {
        private readonly IUnitofWork uow;
        public GenderService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteGenderDTO(int GenderId)
        {
            try
            {
                var getGender = uow.GetRepository<Gender>().Get(z => z.Id == GenderId);
                uow.GetRepository<Gender>().Delete(getGender);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<GenderDTO> getAll()
        {
            var getGenderList = uow.GetRepository<Gender>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<GenderDTO>>(getGenderList);
        }

        public GenderDTO getGender(int Id)
        {
            var getGender = uow.GetRepository<Gender>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<GenderDTO>(getGender);
        }

        public GenderDTO newGender(GenderDTO Gender)
        {
            if (!uow.GetRepository<Gender>().GetAll().Any(z => z.Id == Gender.Id))
            {
                var adedGender = MapperFactory.CurrentMapper.Map<Gender>(Gender);
                adedGender = uow.GetRepository<Gender>().Add(adedGender);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<GenderDTO>(adedGender);
            }
            else
            {
                return null;
            }
        }

        public GenderDTO updateGender(GenderDTO Gender)
        {
            var selectedGender = uow.GetRepository<Gender>().Get(z => z.Id == Gender.Id);
            selectedGender = MapperFactory.CurrentMapper.Map(Gender, selectedGender);
            uow.GetRepository<Gender>().Update(selectedGender);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<GenderDTO>(selectedGender);
        }
    }
}
