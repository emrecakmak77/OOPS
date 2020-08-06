using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class EmployeeDetailDTO
    {
        public Nullable<int> Id { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
        public string TCKN { get; set; }
        public string BirthDate { get; set; }
        public Nullable<int> Children { get; set; }
        public string Nationality { get; set; }
        public string LastCompletedEducationalInstitution { get; set; }
        public Nullable<int> DisabilitySituationID { get; set; }
        public virtual DisabilitySituationDTO DisabilitySituation { get; set; }
        public Nullable<int> EducationStatusID { get; set; }
        public virtual EducationStatusDTO EducationStatus { get; set; }
        public Nullable<int> EducationLevelID { get; set; }
        public virtual EducationLevelDTO EducationLevel { get; set; }
        public Nullable<int> GenderID { get; set; }
        public virtual GenderDTO Gender { get; set; }
        public Nullable<int> MaritalStatusID { get; set; }
        public virtual MaritalStatusDTO MaritalStatus { get; set; }
        public Nullable<int> BloodGroupID { get; set; }
        public virtual BloodGroupDTO BloodGroup { get; set; }
    }
}
