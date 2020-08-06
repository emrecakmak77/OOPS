using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Static;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate.StaticConcreate
{
    public class EmploymentTypeService : IEmploymentTypeService
    {
        private readonly IUnitofWork uow;
        public EmploymentTypeService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteEmploymentTypeDTO(int EmploymentTypeId)
        {
            try
            {
                var getEmploymentType = uow.GetRepository<EmploymentType>().Get(z => z.Id == EmploymentTypeId);
                uow.GetRepository<EmploymentType>().Delete(getEmploymentType);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<EmploymentTypeDTO> getAll()
        {
            var getEmploymentTypeList = uow.GetRepository<EmploymentType>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<EmploymentTypeDTO>>(getEmploymentTypeList);
        }

        public EmploymentTypeDTO getEmploymentType(int Id)
        {
            var getEmploymentType = uow.GetRepository<EmploymentType>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<EmploymentTypeDTO>(getEmploymentType);
        }

        public EmploymentTypeDTO newEmploymentType(EmploymentTypeDTO EmploymentType)
        {
            if (!uow.GetRepository<EmploymentType>().GetAll().Any(z => z.Id == EmploymentType.Id))
            {
                var adedEmploymentType = MapperFactory.CurrentMapper.Map<EmploymentType>(EmploymentType);
                adedEmploymentType = uow.GetRepository<EmploymentType>().Add(adedEmploymentType);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<EmploymentTypeDTO>(adedEmploymentType);
            }
            else
            {
                return null;
            }
        }

        public EmploymentTypeDTO updateEmploymentType(EmploymentTypeDTO EmploymentType)
        {
            var selectedEmploymentType = uow.GetRepository<EmploymentType>().Get(z => z.Id == EmploymentType.Id);
            selectedEmploymentType = MapperFactory.CurrentMapper.Map(EmploymentType, selectedEmploymentType);
            uow.GetRepository<EmploymentType>().Update(selectedEmploymentType);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<EmploymentTypeDTO>(selectedEmploymentType);
        }
    }
}
