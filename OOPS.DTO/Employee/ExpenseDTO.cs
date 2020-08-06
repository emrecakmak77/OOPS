using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class ExpenseDTO
    {
        public int Id { get; set; }
        public string Plug { get; set; }
        public int Sum { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public virtual List<EmployeeExpenseDTO> EmployeeExpenses { get; set; }
    }
}
