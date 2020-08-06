using OOPS.DTO.Company;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class SystemEducationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EducatorName { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan EndTime { get; set; }
        public string EducatorCompany { get; set; }
        public string EducationLocation { get; set; }
        public string ValidityPeriodMonth { get; set; }
        public string Description { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public virtual CompanyDTO Company { get; set; }




    }
}
