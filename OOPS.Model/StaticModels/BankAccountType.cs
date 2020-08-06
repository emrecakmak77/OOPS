using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class BankAccountType : Entity<int>
    {
        public BankAccountType()
        {
            EmployeeOtherInfos = new HashSet<EmployeeOtherInfo>();
        }
        public string BankAccountTypeName { get; set; }
        public virtual ICollection<EmployeeOtherInfo> EmployeeOtherInfos { get; set; }
    }
}
