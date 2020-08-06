using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IEducationStatusService : IServiceBase
    {
        List<EducationStatusDTO> getAll();
        EducationStatusDTO getEducationStatus(int Id);
        EducationStatusDTO newEducationStatus(EducationStatusDTO EducationStatus);
        EducationStatusDTO updateEducationStatus(EducationStatusDTO EducationStatus);
        bool deleteEducationStatusDTO(int EducationStatusId);
    }
}
