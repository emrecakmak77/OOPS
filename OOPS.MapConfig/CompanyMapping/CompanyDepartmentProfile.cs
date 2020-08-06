using OOPS.DTO.Company;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.CompanyModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.MapConfig.CompanyMapping
{
    public class CompanyDepartmentProfile : ProfileBase
    {
        public CompanyDepartmentProfile()
        {
            CreateMap<CompanyDepartment, CompanyDepartmentDTO>().ReverseMap();
        }
    }
}
