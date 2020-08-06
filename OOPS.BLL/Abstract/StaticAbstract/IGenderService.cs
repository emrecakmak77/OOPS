using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IGenderService : IServiceBase
    {
        List<GenderDTO> getAll();
        GenderDTO getGender(int Id);
        GenderDTO newGender(GenderDTO Gender);
        GenderDTO updateGender(GenderDTO Gender);
        bool deleteGenderDTO(int GenderId);
    }
}
