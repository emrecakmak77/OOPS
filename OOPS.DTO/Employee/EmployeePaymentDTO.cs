using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class EmployeePaymentDTO
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
        public int PaymentId { get; set; }
        public virtual PaymentDTO Payment { get; set; }


    }
}
