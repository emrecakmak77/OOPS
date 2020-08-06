using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class BankInformationDTO
    {
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IBAN { get; set; }
        public virtual List<BankAccountTypeDTO> BankAccountTypes { get; set; }

        public virtual List<EmployeeBankInfoDTO> EmployeeBankInfos { get; set; }
    }
}
