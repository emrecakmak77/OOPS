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
    public class AccessTypeService : IAccessTypeService
    {
        private readonly IUnitofWork uow;
        public AccessTypeService(IUnitofWork uow)
        {
            this.uow = uow;
        }


        public bool deleteAccessTypeDTO(int AccessTypeId)
        {
            try
            {
                var getAccessType = uow.GetRepository<AccessType>().Get(z => z.Id == AccessTypeId);
                uow.GetRepository<AccessType>().Delete(getAccessType);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public AccessTypeDTO getAccessType(int Id)
        {
            var getAccessType = uow.GetRepository<AccessType>().GetIncludes(
                                 a => a.Id == Id,
                                 b => b.Employees
                                 );
            return MapperFactory.CurrentMapper.Map<AccessTypeDTO>(getAccessType);
        }

        public List<AccessTypeDTO> getAll()
        {
            var getAccessTypeList = uow.GetRepository<AccessType>().Get(null, null, null).ToList();
            return MapperFactory.CurrentMapper.Map<List<AccessTypeDTO>>(getAccessTypeList);
        }

        public AccessTypeDTO newAccessType(AccessTypeDTO AccessType)
        {
            if (!uow.GetRepository<AccessType>().GetAll().Any(z => z.Id == AccessType.Id))
            {
                var adedAccessType = MapperFactory.CurrentMapper.Map<AccessType>(AccessType);
                adedAccessType = uow.GetRepository<AccessType>().Add(adedAccessType);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<AccessTypeDTO>(adedAccessType);
            }
            else
            {
                return null;
            }
        }

        public AccessTypeDTO updateAccessType(AccessTypeDTO AccessType)
        {
            var selectedAccessType = uow.GetRepository<AccessType>().Get(z => z.Id == AccessType.Id);
            selectedAccessType = MapperFactory.CurrentMapper.Map(AccessType, selectedAccessType);
            uow.GetRepository<AccessType>().Update(selectedAccessType);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<AccessTypeDTO>(selectedAccessType);
        }
    }
}
