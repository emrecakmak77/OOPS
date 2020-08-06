using OOPS.DTO.Company;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.CompanyModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.MapConfig.CompanyMapping
{
    public class CompanyBranchProfile : ProfileBase
    {
        public CompanyBranchProfile()
        {
            CreateMap<CompanyBranch, CompanyBranchDTO>().ReverseMap();
        }
    }
}
