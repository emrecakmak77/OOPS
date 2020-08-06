using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class EducationDTO
    {
        public string Name { get; set; }
        public int EducationsTypeID { get; set; }
        public virtual EducationsTypeDTO EducationsType { get; set; }
        public DateTime DateCompleted { get; set; }
        public virtual List<EmployeeDTO> Employees { get; set; }
    }
}
