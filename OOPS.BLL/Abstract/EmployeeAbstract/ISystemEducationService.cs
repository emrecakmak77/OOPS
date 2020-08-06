using OOPS.Core.Business;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.EmployeeAbstract
{
    public interface ISystemEducationService : IServiceBase
    {
        SystemEducationDTO getSystemEducation(int Id);
        SystemEducationDTO newSystemEducation(SystemEducationDTO SystemEducation);
        SystemEducationDTO updateSystemEducation(SystemEducationDTO SystemEducation);
        bool deleteSystemEducation(int systemEducationId);
        List<SystemEducationDTO> getAllSystemEducations(int Id);
        List<SystemEducationDTO> getAll();
    }
}
