using Microsoft.EntityFrameworkCore;
using OOPS.DAL.MappingConfiguration;
using OOPS.Model.CompanyModels;
using OOPS.Model.EmployeeModel;
using OOPS.Model.ProjectBaseModel;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DAL
{
    public class OOPSEntites : DbContext
    {
        public OOPSEntites(DbContextOptions<OOPSEntites> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Image> Images { get; set; }

        #region companyEntity
        public DbSet<CompanyBranch> CompanyBranches { get; set; }
        public DbSet<CompanyDepartment> CompanyDepartments { get; set; }
        #endregion

        #region employeeEntity
        public DbSet<Advance> Advances { get; set; }
        public DbSet<BankInformation> BankInformations { get; set; }
        public DbSet<EmployeeBankInfo> EmployeeBankInfos { get; set; }
        public DbSet<EmployeeAdvance> EmployeeAdvances { get; set; }
        public DbSet<EmployeeDebit> EmployeeDebits { get; set; }
        public DbSet<EmployeeExpense> EmployeeExpenses { get; set; }
        public DbSet<EmployeeOverTime> EmployeeOverTimes { get; set; }
        public DbSet<EmployeePermit> EmployeePermits { get; set; }
        public DbSet<EmployeePosition> EmployeePositions { get; set; }
        public DbSet<EmployeePayment> EmployeePayments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Debit> Debits { get; set; }
        public DbSet<Demand> Demands { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EducationsType> EducationsTypes { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<EmployeeOtherInfo> EmployeeOtherInfos { get; set; }
        public DbSet<EmployeeSalary> EmployeeSalaries { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Overtime> Overtimes { get; set; }
        public DbSet<Permit> Permits { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<RequestForVisa> RequestForVisas { get; set; }
        public DbSet<EmployeeVisa> EmployeeVisas { get; set; }
        public DbSet<SystemEducation> SystemEducations { get; set; }
        #endregion

        #region StaticEntities
        public DbSet<AccessType> AccessTypes { get; set; }
        public DbSet<BankAccountType> BankAccountTypes { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<ContractType> ContractTypes { get; set; }
        public DbSet<DisabilitySituation> DisabilitySituations { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<EducationStatus> EducationStatuses { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<PermitType> PermitTypes { get; set; }
        public DbSet<VisaType> VisaTypes { get; set; }
        #endregion




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Seed();

            modelBuilder.ApplyConfiguration(new EmployeeMap());

            //modelBuilder.Entity<Employee>().Property(z => z.Name).IsRequired();

            modelBuilder.Entity<EmployeeAdvance>()
            .HasKey(hk => new { hk.EmployeeId, hk.AdvanceId });

            modelBuilder.Entity<EmployeeBankInfo>()
            .HasKey(hk => new { hk.EmployeeId, hk.BankInformationId });

            modelBuilder.Entity<EmployeeDebit>()
            .HasKey(hk => new { hk.Id });

            modelBuilder.Entity<EmployeeExpense>()
            .HasKey(hk => new { hk.EmployeeId, hk.ExpenseId });

            modelBuilder.Entity<EmployeeOverTime>()
            .HasKey(hk => new { hk.EmployeeId, hk.OvertimeId });

            modelBuilder.Entity<EmployeePermit>()
            .HasKey(hk => new { hk.Id });

            modelBuilder.Entity<EmployeeVisa>()
            .HasKey(hk => new { hk.Id });

            modelBuilder.Entity<EmployeeOverTime>()
            .HasKey(hk => new { hk.Id });

        }

    }
}
