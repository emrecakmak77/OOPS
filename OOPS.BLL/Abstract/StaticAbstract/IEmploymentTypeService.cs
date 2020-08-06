using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IEmploymentTypeService : IServiceBase
    {
        List<EmploymentTypeDTO> getAll();
        EmploymentTypeDTO getEmploymentType(int Id);
        EmploymentTypeDTO newEmploymentType(EmploymentTypeDTO EmploymentType);
        EmploymentTypeDTO updateEmploymentType(EmploymentTypeDTO EmploymentType);
        bool deleteEmploymentTypeDTO(int EmploymentTypeId);
    }
}
