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
    public class DistrictService : IDistrictService
    {
        private readonly IUnitofWork uow;
        public DistrictService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteDistrictDTO(int DistrictId)
        {
            try
            {
                var getDistrict = uow.GetRepository<District>().Get(z => z.Id == DistrictId);
                uow.GetRepository<District>().Delete(getDistrict);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<DistrictDTO> getAll()
        {
            var getDistrictList = uow.GetRepository<District>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<DistrictDTO>>(getDistrictList);
        }

        public DistrictDTO getDistrict(int Id)
        {
            var getDistrict = uow.GetRepository<District>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<DistrictDTO>(getDistrict);
        }

        public DistrictDTO newDistrict(DistrictDTO District)
        {
            if (!uow.GetRepository<District>().GetAll().Any(z => z.Id == District.Id))
            {
                var adedDistrict = MapperFactory.CurrentMapper.Map<District>(District);
                adedDistrict = uow.GetRepository<District>().Add(adedDistrict);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<DistrictDTO>(adedDistrict);
            }
            else
            {
                return null;
            }
        }

        public DistrictDTO updateDistrict(DistrictDTO District)
        {
            var selectedDistrict = uow.GetRepository<District>().Get(z => z.Id == District.Id);
            selectedDistrict = MapperFactory.CurrentMapper.Map(District, selectedDistrict);
            uow.GetRepository<District>().Update(selectedDistrict);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<DistrictDTO>(selectedDistrict);
        }
    }
}
