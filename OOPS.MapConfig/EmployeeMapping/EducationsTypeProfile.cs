using OOPS.DTO.Employee;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.MapConfig.EmployeeMapping
{
   public class EducationsTypeProfile : ProfileBase
    {
        public EducationsTypeProfile()
        {
            CreateMap<EducationsType, EducationsTypeDTO>().ReverseMap();
        }
    }
}
