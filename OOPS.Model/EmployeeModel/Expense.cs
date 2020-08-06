using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class Expense
    {
        public Expense()
        {
            EmployeeExpenses = new HashSet<EmployeeExpense>();
        }
        public int Id { get; set; }
        public string Plug { get; set; }
        public int Sum { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EmployeeExpense> EmployeeExpenses { get; set; }
    }
}
