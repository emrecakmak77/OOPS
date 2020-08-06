using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class EmployeeBankInfo
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int BankInformationId { get; set; }
        public virtual BankInformation BankInformation { get; set; }
    }
}
