using OOPS.Core.Business;
using OOPS.DTO.Company;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.CompanyAbstract
{
    public interface ICompanyBranchService : IServiceBase
    {
        List<CompanyBranchDTO> getSelectByCompanyId(int companyId);
        CompanyBranchDTO newCompanyBranch(CompanyBranchDTO CompanyBranch);
        CompanyBranchDTO updateCompanyBranch(CompanyBranchDTO CompanyBranch);
        bool deleteCompanyBranch(int CompanyBranchId);
        CompanyBranchDTO getCompanyBranch(int Id);
        List<CompanyBranchDTO> getAll();
    }
}