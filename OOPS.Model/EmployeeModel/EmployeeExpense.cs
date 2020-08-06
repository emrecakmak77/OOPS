using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class EmployeeExpense
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int ExpenseId { get; set; }
        public virtual Expense Expense { get; set; }
    }
}
