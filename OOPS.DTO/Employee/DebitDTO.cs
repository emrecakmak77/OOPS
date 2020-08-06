using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class DebitDTO
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int SerialNumber { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string Description { get; set; }
        public Nullable<int> DebitCategoryID { get; set; }
        public virtual DebitCategoryDTO DebitCategory { get; set; }
        public virtual List<EmployeeDebitDTO> EmployeeDebits { get; set; }
        
    }
}
