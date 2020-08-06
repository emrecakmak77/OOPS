using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class DemandDTO
    {
        public int Id { get; set; }
        public string DemandType { get; set; }
        public string SubPageId { get; set; }
        public string Description { get; set; }
        public string PageUrL { get; set; }
        public string Icon { get; set; }
    }
}
