using Microsoft.EntityFrameworkCore.Internal;
using OOPS.BLL.Abstract.CompanyAbstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Company;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.CompanyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate.CompanyConcrete
{
    public class CompanyBranchService : ICompanyBranchService
    {
        private readonly IUnitofWork uow;

        public CompanyBranchService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteCompanyBranch(int CompanyBranchId)
        {
            try
            {
                var getCompanyBranch = uow.GetRepository<CompanyBranch>().Get(z => z.Id == CompanyBranchId);
                uow.GetRepository<CompanyBranch>().Delete(getCompanyBranch);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CompanyBranchDTO> getAll()
        {
            var getCompanyBranchList = uow.GetRepository<CompanyBranch>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<CompanyBranchDTO>>(getCompanyBranchList);
        }

        public CompanyBranchDTO getCompanyBranch(int Id)
        {
            var getCompanyBranch = uow.GetRepository<CompanyBranch>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<CompanyBranchDTO>(getCompanyBranch);
        }

        public List<CompanyBranchDTO> getSelectByCompanyId(int companyId)
        {
            var getCompanyBrancListhwithCompanyId = uow.GetRepository<CompanyBranch>().GetAll().Where(z => z.CompanyID == companyId);
            return MapperFactory.CurrentMapper.Map<List<CompanyBranchDTO>>(getCompanyBrancListhwithCompanyId);
        }

        public CompanyBranchDTO newCompanyBranch(CompanyBranchDTO CompanyBranch)
        {

                var adedCompanyBranch = MapperFactory.CurrentMapper.Map<CompanyBranch>(CompanyBranch);
                adedCompanyBranch = uow.GetRepository<CompanyBranch>().Add(adedCompanyBranch);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<CompanyBranchDTO>(adedCompanyBranch);

        }

        public CompanyBranchDTO updateCompanyBranch(CompanyBranchDTO CompanyBranch)
        {
            var selectedCompanyBranch = uow.GetRepository<CompanyBranch>().Get(z => z.Id == CompanyBranch.Id);
            selectedCompanyBranch = MapperFactory.CurrentMapper.Map(CompanyBranch, selectedCompanyBranch);
            uow.GetRepository<CompanyBranch>().Update(selectedCompanyBranch);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<CompanyBranchDTO>(selectedCompanyBranch);
        }


    }
}