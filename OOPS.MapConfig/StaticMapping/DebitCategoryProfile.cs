using OOPS.DTO.Static;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.MapConfig.EmployeeMapping
{
    public class DebitCategoryProfile : ProfileBase
    {
        public DebitCategoryProfile()
        {
            CreateMap<DebitCategory, DebitCategoryDTO>().ReverseMap();
        }
    }
}
