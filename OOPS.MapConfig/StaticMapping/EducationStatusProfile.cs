using OOPS.DTO.Static;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace OOPS.MapConfig.StaticMapping
{
    public class EducationStatusProfile : ProfileBase
    {
        public EducationStatusProfile()
        {
            CreateMap<EducationStatus, EducationStatusDTO>().ReverseMap();
        }
    }
}
