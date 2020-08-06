using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class RequestForVisaDTO
    {
        public int Id { get; set; }
        public string Deadline { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public string Description { get; set; }
        public DateTime TripStartDate { get; set; }
        public TimeSpan TripStartTime { get; set; }
        public DateTime TripEndDate { get; set; }
        public TimeSpan TripEndTime { get; set; }
        public string TripCountry { get; set; }
        public int VisaId { get; set; }
        public VisaTypeDTO VisaType { get; set; }
        public virtual List<EmployeeDTO> Employees { get; set; }
    }
}
