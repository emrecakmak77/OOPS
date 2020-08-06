using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Static
{
    public class DebitCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<DebitDTO> Debits { get; set; }
    }
}
