using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using OOPS.DTO.Company;
using OOPS.DTO.ProjectBase;
using OOPS.DTO.Static;

namespace OOPS.DTO.Employee
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string PhonePersonal { get; set; }
        public string PhoneBusiness { get; set; }
        public string EmailBusiness { get; set; }
        //public string EmailPersonal { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public virtual EmployeeDetailDTO EmployeeDetail { get; set; }
        public virtual EmployeeOtherInfoDTO EmployeeOtherInfo { get; set; }
        public virtual EmploymentTypeDTO EmploymentType { get; set; }

        public Nullable<int> CompanyID { get; set; }
        public virtual CompanyDTO Company { get; set; }

        public Nullable<int> UserID { get; set; }
        public virtual UserDTO User { get; set; }

        public Nullable<int> AccessTypeID { get; set; }
        public virtual AccessTypeDTO AccessType { get; set; }


        public Nullable<int> ContractTypeID { get; set; }
        public virtual ContractTypeDTO ContractType { get; set; }


        public Nullable<int> CompanyBranchID { get; set; }
        public virtual CompanyBranchDTO CompanyBranch { get; set; }

        public Nullable<int> CompanyDepartmentId { get; set; }
        public virtual CompanyDepartmentDTO CompanyDepartment { get; set; }

        public Nullable<int> ImageID { get; set; }
        public virtual ImageDTO Image { get; set; }


        public virtual List<EmployeeAdvanceDTO> EmployeeAdvances { get; set; }
        public virtual List<EmployeeBankInfoDTO> EmployeeBankInfos { get; set; }
        public virtual List<EmployeeDebitDTO> EmployeeDebits { get; set; }
        public virtual List<EmployeeSalaryDTO> EmployeeSalaries { get; set; }
        public virtual List<EmployeeExpenseDTO> EmployeeExpenses { get; set; }
        public virtual List<EmployeeOverTimeDTO> EmployeeOverTimes { get; set; }
        public virtual List<EmployeePermitDTO> EmployeePermits { get; set; }
        public virtual List<EmployeePositionDTO> EmployeePositions { get; set; }
        public virtual List<EmployeeVisaDTO> EmployeeVisas { get; set; }
        public virtual List<EmployeePaymentDTO> EmployeePayments { get; set; }
  
    }
}
