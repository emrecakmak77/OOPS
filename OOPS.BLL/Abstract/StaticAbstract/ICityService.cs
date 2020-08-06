using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface ICityService : IServiceBase
    {
        List<CityDTO> getAll();
        CityDTO getCity(int Id);
        CityDTO newCity(CityDTO City);
        CityDTO updateCity(CityDTO City);
        bool deleteCityDTO(int CityId);
    }
}
