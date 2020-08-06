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
    public class CityService : ICityService
    {
        private readonly IUnitofWork uow;
        public CityService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteCityDTO(int CityId)
        {
            try
            {
                var getCity = uow.GetRepository<City>().Get(z => z.Id == CityId);
                uow.GetRepository<City>().Delete(getCity);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CityDTO> getAll()
        {
            var getCityList = uow.GetRepository<City>().Get(null, null, null).ToList();
            return MapperFactory.CurrentMapper.Map<List<CityDTO>>(getCityList);
        }

        public CityDTO getCity(int Id)
        {
            var getCity = uow.GetRepository<City>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<CityDTO>(getCity);
        }

        public CityDTO newCity(CityDTO City)
        {
            if (!uow.GetRepository<City>().GetAll().Any(z => z.Id == City.Id))
            {
                var adedCity = MapperFactory.CurrentMapper.Map<City>(City);
                adedCity = uow.GetRepository<City>().Add(adedCity);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<CityDTO>(adedCity);
            }
            else
            {
                return null;
            }
        }

        public CityDTO updateCity(CityDTO City)
        {
            var selectedCity = uow.GetRepository<City>().Get(z => z.Id == City.Id);
            selectedCity = MapperFactory.CurrentMapper.Map(City, selectedCity);
            uow.GetRepository<City>().Update(selectedCity);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<CityDTO>(selectedCity);
        }
    }
}
