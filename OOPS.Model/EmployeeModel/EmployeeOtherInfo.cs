using OOPS.Core.Entities;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class EmployeeOtherInfo : Entity<int>
    {
        [ForeignKey("Employee")]
        public Nullable<int> EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
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

        [ForeignKey("District")]
        public Nullable<int> DistrictId { get; set; }
        public virtual District District { get; set; }
        // department

        [ForeignKey("Country")]
        public Nullable<int> CountryId { get; set; }
        public virtual Country Country { get; set; }

        [ForeignKey("City")]
        public Nullable<int> CityId { get; set; }
        public virtual City City { get; set; }

        [ForeignKey("BankAccountType")]
        public Nullable<int> BankAccountTypeId { get; set; }
        public virtual BankAccountType BankAccountType { get; set; }
    }
}
