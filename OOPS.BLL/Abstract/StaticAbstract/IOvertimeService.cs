using OOPS.Core.Business;
using OOPS.DTO.Employee;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IOvertimeService : IServiceBase
    {
        List<OvertimeDTO> getAllEmployeeOvertimes();
        List<OvertimeDTO> getAllEmployeeOvertimesByCompanyId(int companyId);
        OvertimeDTO getOvertime(int Id);
        List<OvertimeDTO> getEmployeeOvertimes(int emloyeeId);
        OvertimeDTO newOvertime(OvertimeDTO Overtime);
        OvertimeDTO updateOvertime(OvertimeDTO Overtime);
    }
}
