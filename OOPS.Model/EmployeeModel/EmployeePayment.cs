using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class EmployeePayment : Entity<int>
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; }

    }
}
