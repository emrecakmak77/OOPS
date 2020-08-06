using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IDistrictService : IServiceBase
    {
        List<DistrictDTO> getAll();
        DistrictDTO getDistrict(int Id);
        DistrictDTO newDistrict(DistrictDTO District);
        DistrictDTO updateDistrict(DistrictDTO District);
        bool deleteDistrictDTO(int DistrictId);
    }
}
