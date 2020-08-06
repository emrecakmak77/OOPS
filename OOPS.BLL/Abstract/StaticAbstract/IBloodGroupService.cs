using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IBloodGroupService : IServiceBase
    {
        List<BloodGroupDTO> getAll();
        BloodGroupDTO getBloodGroup(int Id);
        BloodGroupDTO newBloodGroup(BloodGroupDTO BloodGroup);
        BloodGroupDTO updateBloodGroup(BloodGroupDTO BloodGroup);
        bool deleteBloodGroupDTO(int BloodGroupId);
    }
}
