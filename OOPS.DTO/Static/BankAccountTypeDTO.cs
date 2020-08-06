using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Static
{
    public class BankAccountTypeDTO
    {
        public int Id { get; set; }
        public string BankAccountTypeName { get; set; }
        public List<EmployeeOtherInfoDTO> EmployeeOtherInfos { get; set; }
    }
}
