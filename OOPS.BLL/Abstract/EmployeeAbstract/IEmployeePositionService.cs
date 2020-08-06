using OOPS.Core.Business;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.EmployeeAbstract
{
    public interface IEmployeePositionService : IServiceBase
    {
        List<EmployeePositionDTO> getEmployeePosition(int Id);
        EmployeePositionDTO newEmployeePosition(EmployeePositionDTO employeeDetail);
        EmployeePositionDTO updateEmployeePosition(EmployeePositionDTO employeeDetail);
    }
}
