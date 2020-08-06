using OOPS.DTO.Employee;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.MapConfig.EmployeeMapping
{
   public class EmployeeExpenseProfile : ProfileBase
    {
        public EmployeeExpenseProfile()
        {
            CreateMap<EmployeeExpense, EmployeeExpenseDTO>().ReverseMap();
        }
    }
}
