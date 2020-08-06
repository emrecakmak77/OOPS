using OOPS.DTO.Static;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.MapConfig.StaticMapping
{
    public class VisaDocumentRequestsProfile : ProfileBase
    {
        public VisaDocumentRequestsProfile()
        {
            CreateMap<VisaDocumentRequests, VisaDocumentRequestDTO>().ReverseMap();
        }
    }
}
