using OOPS.Core.Business;
using OOPS.DTO.Company;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.CompanyAbstract
{
    public interface ICompanyService : IServiceBase
    {
        CompanyDTO newCompany(CompanyDTO company);
        CompanyDTO updateCompany(CompanyDTO company);
        bool deleteCompany(int companyId);
        CompanyDTO getCompany(int Id);
        CompanyDTO getCompanyInfo(int Id);
        List<CompanyDTO> getAll(int companyId);

    }
}
