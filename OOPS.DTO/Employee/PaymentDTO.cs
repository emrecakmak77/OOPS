using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class PaymentDTO
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Description { get; set; }
        public string EmployeeFullName { get; set; }
        public virtual List<EmployeePaymentDTO> EmployeePayments { get; set; }
    }
}
