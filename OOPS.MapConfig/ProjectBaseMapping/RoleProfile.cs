using OOPS.DTO.ProjectBase;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.ProjectBaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Mapping.ProjectBaseMapping
{
    public class RoleProfile : ProfileBase
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleDTO>().ReverseMap();
        }
    }
}
