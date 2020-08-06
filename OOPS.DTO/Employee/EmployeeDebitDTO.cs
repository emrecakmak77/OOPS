using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class EmployeeDebitDTO
    {
        public int EmployeeId { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
        public int DebitId { get; set; }
        public virtual DebitDTO Debit { get; set; }
    }
}
