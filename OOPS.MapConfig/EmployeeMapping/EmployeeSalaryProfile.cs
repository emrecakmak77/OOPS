using OOPS.DTO.Employee;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.MapConfig.EmployeeMapping
{
   public class EmployeeSalaryProfile : ProfileBase
    {
        public EmployeeSalaryProfile()
        {
            CreateMap<EmployeeSalary, EmployeeSalaryDTO>().ReverseMap();
        }
    }
}
