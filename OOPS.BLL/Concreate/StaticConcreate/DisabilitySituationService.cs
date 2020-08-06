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
    public class DisabilitySituationService : IDisabilitySituationService
    {
        private readonly IUnitofWork uow;
        public DisabilitySituationService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteDisabilitySituationDTO(int DisabilitySituationId)
        {
            try
            {
                var getDisablitySituation = uow.GetRepository<DisabilitySituation>().Get(z => z.Id == DisabilitySituationId);
                uow.GetRepository<DisabilitySituation>().Delete(getDisablitySituation);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<DisabilitySituationDTO> getAll()
        {
            var getDisablitySituationList = uow.GetRepository<DisabilitySituation>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<DisabilitySituationDTO>>(getDisablitySituationList);
        }

        public DisabilitySituationDTO getDisabilitySituation(int Id)
        {
            var getDisablitySituation = uow.GetRepository<DisabilitySituation>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<DisabilitySituationDTO>(getDisablitySituation);
        }

        public DisabilitySituationDTO newDisabilitySituation(DisabilitySituationDTO DisabilitySituation)
        {
            if (!uow.GetRepository<Country>().GetAll().Any(z => z.Id == DisabilitySituation.Id))
            {
                var adedDisabilitySituation = MapperFactory.CurrentMapper.Map<DisabilitySituation>(DisabilitySituation);
                adedDisabilitySituation = uow.GetRepository<DisabilitySituation>().Add(adedDisabilitySituation);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<DisabilitySituationDTO>(adedDisabilitySituation);
            }
            else
            {
                return null;
            }
        }

        public DisabilitySituationDTO updateDisabilitySituation(DisabilitySituationDTO DisabilitySituation)
        {
            var selectedDisabilitySituation = uow.GetRepository<DisabilitySituation>().Get(z => z.Id == DisabilitySituation.Id);
            selectedDisabilitySituation = MapperFactory.CurrentMapper.Map(DisabilitySituation, selectedDisabilitySituation);
            uow.GetRepository<DisabilitySituation>().Update(selectedDisabilitySituation);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<DisabilitySituationDTO>(selectedDisabilitySituation);
        }
    }
}
