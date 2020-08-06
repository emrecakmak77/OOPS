using OOPS.Core.Entities;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
   public class EmployeeVisa : Entity<int>
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int VisaDocumentRequestsId { get; set; }
        public virtual VisaDocumentRequests VisaDocumentRequests { get; set; }
    }
}
