using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class EmployeeBankInfoDTO
    {
        public int EmployeeId { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
        public int BankInformationId { get; set; }
        public virtual BankInformationDTO BankInformation { get; set; }
    }
}
