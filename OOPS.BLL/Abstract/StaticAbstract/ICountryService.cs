using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface ICountryService : IServiceBase
    {
        List<CountryDTO> getAll();
        CountryDTO getCountry(int Id);
        CountryDTO newCountry(CountryDTO Country);
        CountryDTO updateCountry(CountryDTO Country);
        bool deleteCountryDTO(int CountryId);
    }
}
