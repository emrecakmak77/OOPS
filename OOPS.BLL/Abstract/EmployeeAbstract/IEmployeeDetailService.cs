using OOPS.Core.Business;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.EmployeeAbstract
{
    public interface IEmployeeDetailService : IServiceBase
    {
        List<EmployeeDetailDTO> getAll();
        EmployeeDetailDTO getEmployeeDetail(int Id);
        EmployeeDetailDTO newEmployeeDetail(EmployeeDetailDTO employeeDetail);
        EmployeeDetailDTO updateEmployeeDetail(EmployeeDetailDTO employeeDetail);
        bool deleteEmployeeDetail(int employeeDetailId);
    }
}

