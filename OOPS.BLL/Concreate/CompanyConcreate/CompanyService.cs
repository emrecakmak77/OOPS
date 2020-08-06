
using OOPS.BLL.Abstract.CompanyAbstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Company;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.CompanyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate.CompanyConcreate
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitofWork uow;
        public CompanyService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteCompany(int companyId)
        {
            try
            {
                var getCompany = uow.GetRepository<Company>().Get(z => z.Id == companyId);
                uow.GetRepository<Company>().Delete(getCompany);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public List<CompanyDTO> getAll(int companyId)
        {
            var getCompanytList = uow.GetRepository<Company>().GetAll().Where(z => z.Id == companyId);
            return MapperFactory.CurrentMapper.Map<List<CompanyDTO>>(getCompanytList);
        }

        public CompanyDTO getCompany(int Id)
        {
            var getCompany = uow.GetRepository<Company>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<CompanyDTO>(getCompany);
        }

        public CompanyDTO getCompanyInfo(int Id)
        {
            var getEmployee = uow.GetRepository<Company>()
       .GetIncludes(a => a.Id == Id,
                    b => b.CompanyBranches,
                    c => c.CompanyDepartments
                    );
            return MapperFactory.CurrentMapper.Map<CompanyDTO>(getEmployee);
        }

        public CompanyDTO newCompany(CompanyDTO company)
        {
            if (!uow.GetRepository<Company>().GetAll().Any(z => z.CompanyName == company.CompanyName))
            {
                var adedCompany = MapperFactory.CurrentMapper.Map<Company>(company);
                adedCompany = uow.GetRepository<Company>().Add(adedCompany);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<CompanyDTO>(adedCompany);
            }
            else
            {
                return null;
            }
        }

        public CompanyDTO updateCompany(CompanyDTO company)
        {
            var selectedCompany = uow.GetRepository<Company>().Get(z => z.Id == company.Id);
            selectedCompany = MapperFactory.CurrentMapper.Map(company, selectedCompany);
            uow.GetRepository<Company>().Update(selectedCompany);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<CompanyDTO>(selectedCompany);
        }
    }
}
