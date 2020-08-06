using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class RequestForVisa
    {
        public RequestForVisa()
        {
            Employees = new HashSet<Employee>();
        }
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

        [ForeignKey("VisaType")]
        public int VisaId { get; set; }
        public virtual VisaType VisaType { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
