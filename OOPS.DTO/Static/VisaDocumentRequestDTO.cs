using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Static
{
    public class VisaDocumentRequestDTO
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        //public string Deadline { get; set; }
        public DateTime DeadlineDate { get; set; }
        public TimeSpan DeadlineTime { get; set; }
        public string TripCountry { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public DateTime TripStartDate { get; set; }
        public TimeSpan TripStartTime { get; set; }
        public DateTime TripEndDate { get; set; }
        public TimeSpan TripEndTime { get; set; }
        public string Description { get; set; }
        public Nullable<int> VisaTypeId { get; set; }
        public virtual VisaTypeDTO VisaType { get; set; }

    }
}
