using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IEducationLevelService : IServiceBase
    {
        List<EducationLevelDTO> getAll();
        EducationLevelDTO getEducationLevel(int Id);
        EducationLevelDTO newEducationLevel(EducationLevelDTO EducationLevel);
        EducationLevelDTO updateEducationLevel(EducationLevelDTO EducationLevel);
        bool deleteEducationLevelDTO(int EducationLevelId);
    }
}
