using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class EmployeeVisaDTO
    {
        public int EmployeeId { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
        public int VisaDocumentRequestsId { get; set; }
        public virtual VisaDocumentRequestDTO VisaDocumentRequests { get; set; }
    }
}
