using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class EmployeeSalary : Entity<int>
    {
        public string SalaryName { get; set; }
        public int Amount { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
