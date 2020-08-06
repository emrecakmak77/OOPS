using OOPS.DTO.Company;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.CompanyModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Mapping.CompanyMapping
{
    public class CompanyProfile :ProfileBase
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDTO>().ReverseMap();
        }
    }
}
