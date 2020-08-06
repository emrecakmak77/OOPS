using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
   public class EmployeeExpenseDTO
    {
        public int EmployeeId { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
        public int ExpenseId { get; set; }
        public virtual ExpenseDTO Expense { get; set; }

    }
}
