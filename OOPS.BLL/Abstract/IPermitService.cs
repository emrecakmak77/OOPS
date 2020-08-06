using OOPS.Core.Business;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract
{
    public interface IPermitService : IServiceBase
    {
        List<PermitDTO> getAllEmployeePermits();
        List<EmployeePermitDTO> getEmployeePermits();
        List<PermitDTO> getAllEmployeePermitsByCompanyId(int companyId);
        PermitDTO getPermit(int Id);
        List<PermitDTO> getEmployeePermits(int employeeId);
        PermitDTO newPermit(PermitDTO Permit);
        PermitDTO updatePermit(PermitDTO Permit);
    }
}