using OOPS.Core.Business;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.EmployeeAbstract
{
    public interface IEmployeeOtherInfoService : IServiceBase
    {
        EmployeeOtherInfoDTO getEmployeeOtherInfo(int Id);
        EmployeeOtherInfoDTO newEmployeeOtherInfo(EmployeeOtherInfoDTO employeeOtherInfo);
        EmployeeOtherInfoDTO updateEmployeeOtherInfo(EmployeeOtherInfoDTO employeeOtherInfo);
        bool deleteEmployeeOtherInfo(int employeeOtherInfoId);
    }
}
