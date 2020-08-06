using OOPS.DTO.Employee;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.MapConfig.EmployeeMapping
{
   public class OvertimeProfile : ProfileBase
    {
        public OvertimeProfile()
        {
            CreateMap<Overtime, OvertimeDTO>().ReverseMap();
        }
    }
}
