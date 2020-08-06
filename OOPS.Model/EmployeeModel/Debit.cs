using OOPS.Core.Entities;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class Debit : Entity<int>
    {
        public Debit()
        {
            //EmployeeDebits = new HashSet<EmployeeDebit>();
        }

        public int SerialNumber { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string Description { get; set; }

        [ForeignKey("DebitCategory")]
        public Nullable<int> DebitCategoryID { get; set; }
        public virtual DebitCategory DebitCategory { get; set; }

        //public virtual ICollection<EmployeeDebit> EmployeeDebits { get; set; }
    }
}
