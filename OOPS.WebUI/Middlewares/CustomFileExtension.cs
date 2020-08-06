using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.CompanyAbstract;
using OOPS.BLL.Abstract.Employee;
using OOPS.BLL.Abstract.EmployeeAbstract;
using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.BLL.Concreate;
using OOPS.BLL.Concreate.CompanyConcreate;
using OOPS.BLL.Concreate.CompanyConcrete;
using OOPS.BLL.Concreate.EmployeConcreate;
using OOPS.BLL.Concreate.EmployeeConcreate;
using OOPS.BLL.Concreate.StaticConcreate;
using OOPS.Core.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Middlewares
{
    public static class CustomFileExtension
    {
        public static void UseSingletonStaticFiles(this IServiceCollection services)
        {
            services.AddSingleton<IUnitofWork, UnitofWork>();
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IRoleService, RoleService>();
            services.AddSingleton<IEmployeeService, EmployeeService>();
            services.AddSingleton<IAccessTypeService, AccessTypeService>();
            services.AddSingleton<IBankAccountTypeService, BankAccountTypeService>();
            services.AddSingleton<IBloodGroupService, BloodGroupService>();
            services.AddSingleton<ICityService, CityService>();
            services.AddSingleton<IContractTypeService, ContractTypeService>();
            services.AddSingleton<ICountryService, CountryService>();
            services.AddSingleton<IDebitService, DebitService>();
            services.AddSingleton<IDebitCategoryService, DebitCategoryService>();
            services.AddSingleton<IDisabilitySituationService, DisabilitySituationService>();
            services.AddSingleton<IDistrictService, DistrictService>();
            services.AddSingleton<IEducationLevelService, EducationLevelService>();
            services.AddSingleton<IEducationStatusService, EducationStatusService>();
            services.AddSingleton<IEmploymentTypeService, EmploymentTypeService>();
            services.AddSingleton<IGenderService, GenderService>();
            services.AddSingleton<IMaritalStatusService, MaritalStatusService>();
            services.AddSingleton<IPermitTypeService, PermitTypeService>();
            services.AddSingleton<IPermitService, PermitService>();
            services.AddSingleton<IPublicHolidaysService, PublicHolidaysService>();
            services.AddSingleton<IEmployeeDetailService, EmployeDetailService>();
            services.AddSingleton<ICompanyService, CompanyService>();
            services.AddSingleton<ISystemEducationService, SystemEducationService>();
            services.AddSingleton<IEmployeeOtherInfoService, EmployeeOtherInfoService>();
            services.AddSingleton<IActivityCalenderService, ActivityCalenderService>();
            services.AddSingleton<IOvertimeRequestsService, OvertimeRequestsService>();
            services.AddSingleton<IPositionService, PositionService>();
            services.AddSingleton<ICompanyBranchService, CompanyBranchService>();
            services.AddSingleton<ICompanyDepartmentService, CompanyDepartmentService>();
            services.AddSingleton<IEmployeePositionService, EmployeePositionService>();
            services.AddSingleton<IVisaDocumentRequestsService, VisaDocumentRequestsService>();
            services.AddSingleton<IVisaTypeService, VisaTypeService>();
            services.AddSingleton<IAdvanceService, AdvanceService>();
            services.AddSingleton<IPaymentsService, PaymentsService>();
            services.AddSingleton<IOvertimeService, OvertimeService>();
            services.AddSingleton<ISalaryService, EmployeeSalaryService>();
        }
    }
}
