using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class EmployeeOtherInfoDTO
    {
        public Nullable<int> Id { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
        public string AdressInfo { get; set; }
        public string AdressFull { get; set; }
        public string HomePhone { get; set; }
        public string PostalCode { get; set; }
        public string CityName { get; set; }
        public string BankName { get; set; }
        public string BankAccountNo { get; set; }
        public string IBAN { get; set; }
        public string ContactNameforEmergency { get; set; }
        public string RelationshipforEmergencyContact { get; set; }
        public string NumberforEmergencyContact { get; set; }
        public string SocialMediaConnectionName { get; set; }
        public string SocialMediaConnectionAddress { get; set; }

        public Nullable<int> DistrictId { get; set; }
        public virtual DistrictDTO District { get; set; }

        public Nullable<int> CountryId { get; set; }
        public virtual CountryDTO Country { get; set; }

        public Nullable<int> CityId { get; set; }
        public virtual CityDTO City { get; set; }


        public Nullable<int> BankAccountTypeId { get; set; }
        public virtual BankAccountTypeDTO BankAccountType { get; set; }
    }
}
