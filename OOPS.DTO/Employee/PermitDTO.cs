using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class PermitDTO
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan StartHour { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan EndHour { get; set; }
        public string Duration { get; set; }
        public Nullable<int> PermitTypeID { get; set; }
        public virtual PermitTypeDTO PermitType { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
        public string Description { get; set; }
        public DateTime StartWorkDate { get; set; }
        public DateTime CreateDate { get; set; }
        public TimeSpan CreateHour { get; set; }
        public string Status { get; set; }
        public string Signed { get; set; }
    }
}
