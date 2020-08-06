using OOPS.Core.Business;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace OOPS.BLL.Abstract.EmployeeAbstract
{
    public interface IEducationService : IServiceBase
    {
        EducationDTO getEducation(int Id);
        List<EducationDTO> getEducations(int educationId);
        EducationDTO newEducation(EducationDTO Education);
        EducationDTO updateEducation(EducationDTO Education);
        bool deleteEducation(int educationId);


    }
}
