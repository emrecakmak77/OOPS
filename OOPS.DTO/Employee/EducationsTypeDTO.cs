using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class EducationsTypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<EducationDTO> Educations { get; set; }

    }
}
