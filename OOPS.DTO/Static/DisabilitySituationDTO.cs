using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Static
{
    public class DisabilitySituationDTO
    {
        public int Id { get; set; }
        public string DisabilityName { get; set; }

        public virtual List<EmployeeDetailDTO> EmployeeDetails { get; set; }
    }
}
