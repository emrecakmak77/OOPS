using OOPS.DTO.ProjectBase;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.ProjectBaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.MapConfig.ProjectBaseMapping
{
    public class ImageProfile : ProfileBase
    {
        public ImageProfile()
        {
            CreateMap<Image, ImageDTO>().ReverseMap();
        }
    }
}
