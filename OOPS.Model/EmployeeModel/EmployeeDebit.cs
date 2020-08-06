using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class EmployeeDebit: Entity<int>
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int DebitId { get; set; }
        public virtual Debit Debit { get; set; }
    }
}
