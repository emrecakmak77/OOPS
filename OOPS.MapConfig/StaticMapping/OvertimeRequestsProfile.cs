using OOPS.DTO.Static;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.MapConfig.StaticMapping
{
   public class OvertimeRequestsProfile : ProfileBase
    {
        public OvertimeRequestsProfile()
        {
            CreateMap<OvertimeRequests, OvertimeRequestsDTO>().ReverseMap();
        }
    }
}
