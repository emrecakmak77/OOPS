using OOPS.Core.Entities;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class BankInformation : Entity<int>
    {
        public BankInformation()
        {
            EmployeeBankInfos = new HashSet<EmployeeBankInfo>();
            BankAccountTypes = new HashSet<BankAccountType>();
        }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IBAN { get; set; }

        public virtual ICollection<BankAccountType> BankAccountTypes { get; set; }

        public virtual ICollection<EmployeeBankInfo> EmployeeBankInfos { get; set; }
    }
}
