using OOPS.DTO.Static;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.MapConfig.StaticMapping
{
    public class BankAccountTypeProfile : ProfileBase
    {
        public BankAccountTypeProfile()
        {
            CreateMap<BankAccountType, BankAccountTypeDTO>().ReverseMap(); 
        }
    }
}
