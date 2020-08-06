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
    public class CompanyDepartmentService : ICompanyDepartmentService
    {
        private readonly IUnitofWork uow;
        public CompanyDepartmentService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteDepartmant(int DepartmantId)
        {
            try
            {
                var getDepartment = uow.GetRepository<CompanyDepartment>().Get(z => z.Id == DepartmantId);
                uow.GetRepository<CompanyDepartment>().Delete(getDepartment);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CompanyDepartmentDTO> getAll()
        {
            var getDepartmentList = uow.GetRepository<CompanyDepartment>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<CompanyDepartmentDTO>>(getDepartmentList);
        }

        public CompanyDepartmentDTO getDepartmant(int Id)
        {
            var getDepartment = uow.GetRepository<CompanyDepartment>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<CompanyDepartmentDTO>(getDepartment);
        }

        public List<CompanyDepartmentDTO> getSelectByCompanyId(int companyId)
        {
            var getCompanyDepartmenrListhwithCompanyId = uow.GetRepository<CompanyDepartment>().GetAll().Where(z => z.CompanyID == companyId);
            return MapperFactory.CurrentMapper.Map<List<CompanyDepartmentDTO>>(getCompanyDepartmenrListhwithCompanyId);
        }

        public CompanyDepartmentDTO newDepartmant(CompanyDepartmentDTO companyDeparment)
        {

                var adedCompanyDepartment = MapperFactory.CurrentMapper.Map<CompanyDepartment>(companyDeparment);
                adedCompanyDepartment = uow.GetRepository<CompanyDepartment>().Add(adedCompanyDepartment);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<CompanyDepartmentDTO>(adedCompanyDepartment);

        }

        public CompanyDepartmentDTO updateDepartmant(CompanyDepartmentDTO companyDeparment)
        {
            var selectedDepartment = uow.GetRepository<CompanyDepartment>().Get(z => z.Id == companyDeparment.Id);
            selectedDepartment = MapperFactory.CurrentMapper.Map(companyDeparment, selectedDepartment);
            uow.GetRepository<CompanyDepartment>().Update(selectedDepartment);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<CompanyDepartmentDTO>(selectedDepartment);
        }
    }
}