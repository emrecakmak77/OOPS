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
    public class CountryService : ICountryService
    {
        private readonly IUnitofWork uow;
        public CountryService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteCountryDTO(int CountryId)
        {
            try
            {
                var getCountry = uow.GetRepository<Country>().Get(z => z.Id == CountryId);
                uow.GetRepository<Country>().Delete(getCountry);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CountryDTO> getAll()
        {
            var getCountryList = uow.GetRepository<Country>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<CountryDTO>>(getCountryList);
        }

        public CountryDTO getCountry(int Id)
        {
            var getCountry = uow.GetRepository<Country>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<CountryDTO>(getCountry);
        }

        public CountryDTO newCountry(CountryDTO Country)
        {
            if (!uow.GetRepository<Country>().GetAll().Any(z => z.Id == Country.Id))
            {
                var adedCountry = MapperFactory.CurrentMapper.Map<Country>(Country);
                adedCountry = uow.GetRepository<Country>().Add(adedCountry);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<CountryDTO>(adedCountry);
            }
            else
            {
                return null;
            }
        }

        public CountryDTO updateCountry(CountryDTO Country)
        {
            var selectedCountry = uow.GetRepository<Country>().Get(z => z.Id == Country.Id);
            selectedCountry = MapperFactory.CurrentMapper.Map(Country, selectedCountry);
            uow.GetRepository<Country>().Update(selectedCountry);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<CountryDTO>(selectedCountry);
        }
    }
}
