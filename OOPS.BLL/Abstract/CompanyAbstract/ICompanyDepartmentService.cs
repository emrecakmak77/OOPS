
using OOPS.Core.Business;
using OOPS.DTO.Company;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.CompanyAbstract
{
    public interface ICompanyDepartmentService : IServiceBase
    {
        List<CompanyDepartmentDTO> getSelectByCompanyId(int companyId);
        CompanyDepartmentDTO newDepartmant(CompanyDepartmentDTO companyDeparment);
        CompanyDepartmentDTO updateDepartmant(CompanyDepartmentDTO companyDeparment);
        bool deleteDepartmant(int DepartmantId);
        CompanyDepartmentDTO getDepartmant(int Id);
        List<CompanyDepartmentDTO> getAll();
    }
}