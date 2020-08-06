using OOPS.Core.Entities;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class Permit : Entity<int>
    {
        public Permit()
        {
            EmployeePermits = new HashSet<EmployeePermit>();
        }
        public DateTime StartDate { get; set; }
        public TimeSpan StartHour { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan EndHour { get; set; }

        public string Duration { get; set; }

        [ForeignKey("PermitType")]
        public Nullable<int> PermitTypeID { get; set; }
        public virtual PermitType PermitType { get; set; }

        public string Description { get; set; }
        public DateTime StartWorkDate { get; set; }
        public DateTime CreateDate { get; set; }
        public TimeSpan CreateHour { get; set; }
        public string Status { get; set; }
        public string Signed { get; set; }
        public virtual ICollection<EmployeePermit> EmployeePermits { get; set; }
    }
}
