using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class VisaDocumentRequests : Entity<int>
    {
        public VisaDocumentRequests()
        {
            EmployeeVisas = new HashSet<EmployeeVisa>();
        }
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

        [ForeignKey("VisaType")]
        public Nullable<int> VisaTypeId { get; set; }
        public virtual VisaType VisaType { get; set; }

        public virtual ICollection<EmployeeVisa> EmployeeVisas { get; set; }

    }
}
