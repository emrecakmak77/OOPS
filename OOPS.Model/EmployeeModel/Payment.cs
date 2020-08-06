using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class Payment : Entity<int>
    {
        public Payment()
        {
            EmployeePayments = new HashSet<EmployeePayment>();
        }
        public string Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Description { get; set; }
        public string EmployeeFullName { get; set; }
        public virtual ICollection<EmployeePayment> EmployeePayments { get; set; }


    }
}
