using OOPS.Core.Entities;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class EmployeeDetail : Entity<int>
    {
        [ForeignKey("Employee")]
        public Nullable<int> EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        public string TCKN { get; set; }

        public string BirthDate { get; set; }

        public Nullable<int> Children { get; set; }
        public string Nationality { get; set; }

        public string LastCompletedEducationalInstitution { get; set; }

        [ForeignKey("DisabilitySituation")]
        public Nullable<int> DisabilitySituationID { get; set; }
        public virtual DisabilitySituation DisabilitySituation { get; set; }

        [ForeignKey("EducationStatus")]
        public Nullable<int> EducationStatusID { get; set; }
        public virtual EducationStatus EducationStatus { get; set; }

        [ForeignKey("EducationLevel")]
        public Nullable<int> EducationLevelID { get; set; }
        public virtual EducationLevel EducationLevel { get; set; }

        [ForeignKey("Gender")]
        public Nullable<int> GenderID { get; set; }
        public virtual Gender Gender { get; set; }

        [ForeignKey("MaritalStatus")]
        public Nullable<int> MaritalStatusID { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }

        [ForeignKey("BloodGroup")]
        public Nullable<int> BloodGroupID { get; set; }
        public virtual BloodGroup BloodGroup { get; set; }
    }
}
