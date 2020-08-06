using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class Demand : Entity<int>
    {
        public string DemandType { get; set; }
        public string SubPageId { get; set; }
        public string Description { get; set; }
        public string PageUrL { get; set; }
        public string Icon { get; set; }
    }
}
