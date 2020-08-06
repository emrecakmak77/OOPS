using OOPS.Core.Entities;
using OOPS.Model.CompanyModels;
using OOPS.Model.ProjectBaseModel;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class Employee : Entity<int>
    {
        public Employee()
        {
            EmployeeAdvances = new HashSet<EmployeeAdvance>();
            EmployeeBankInfos = new HashSet<EmployeeBankInfo>();
            EmployeeDebits = new HashSet<EmployeeDebit>();
            EmployeeSalaries = new HashSet<EmployeeSalary>();
            EmployeeExpenses = new HashSet<EmployeeExpense>();
            EmployeeOverTimes = new HashSet<EmployeeOverTime>();
            EmployeePermits = new HashSet<EmployeePermit>();
            EmployeePositions = new HashSet<EmployeePosition>();
            EmployeeVisas = new HashSet<EmployeeVisa>();
            EmployeePayments = new HashSet<EmployeePayment>();

        }
        [Required(ErrorMessage = "İsim Alanı boş geçilemez!!!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyadı Alanı boş geçilemez!!!")]
        public string Surname { get; set; }
        public string Title { get; set; }

        public string PhonePersonal { get; set; }
        public string PhoneBusiness { get; set; }
        public string EmailBusiness { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public virtual EmployeeDetail EmployeeDetail { get; set; }
        public virtual EmployeeOtherInfo EmployeeOtherInfo { get; set; }
        public virtual EmploymentType EmploymentType { get; set; }

        [ForeignKey("Company")]
        public Nullable<int> CompanyID { get; set; }
        public virtual Company Company { get; set; }

        [ForeignKey("User")]
        public Nullable<int> UserID { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("AccessType")]
        public Nullable<int> AccessTypeID { get; set; }
        public virtual AccessType AccessType { get; set; }


        [ForeignKey("ContractType")]
        public Nullable<int> ContractTypeID { get; set; }
        public virtual ContractType ContractType { get; set; }

        [ForeignKey("CompanyBranch")]
        public Nullable<int> CompanyBranchID { get; set; }
        public virtual CompanyBranch CompanyBranch { get; set; }

        [ForeignKey("CompanyDepartment")]
        public Nullable<int> CompanyDepartmentId { get; set; }
        public virtual CompanyDepartment CompanyDepartment { get; set; }

        [ForeignKey("Image")]
        public Nullable<int> ImageID { get; set; }
        public virtual Image Image { get; set; }


        public virtual ICollection<EmployeeAdvance> EmployeeAdvances { get; set; }
        public virtual ICollection<EmployeeBankInfo> EmployeeBankInfos { get; set; }
        public virtual ICollection<EmployeeDebit> EmployeeDebits { get; set; }
        public virtual ICollection<EmployeeSalary> EmployeeSalaries { get; set; }
        public virtual ICollection<EmployeeExpense> EmployeeExpenses { get; set; }
        public virtual ICollection<EmployeeOverTime> EmployeeOverTimes { get; set; }
        public virtual ICollection<EmployeePermit> EmployeePermits { get; set; }
        public virtual ICollection<EmployeePosition> EmployeePositions { get; set; }
        public virtual ICollection<EmployeeVisa> EmployeeVisas { get; set; }
        public virtual ICollection<EmployeePayment> EmployeePayments { get; set; }


    }
}
