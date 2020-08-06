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
    public class PermitTypeService : IPermitTypeService
    {
        private readonly IUnitofWork uow;
        public PermitTypeService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deletePermitTypeDTO(int PermitTypeId)
        {
            try
            {
                var getPermitType = uow.GetRepository<PermitType>().Get(z => z.Id == PermitTypeId);
                uow.GetRepository<PermitType>().Delete(getPermitType);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<PermitTypeDTO> getAll()
        {
            var getPermitTypeList = uow.GetRepository<PermitType>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<PermitTypeDTO>>(getPermitTypeList);
        }

        public PermitTypeDTO getPermitType(int Id)
        {
            var getPermitType = uow.GetRepository<PermitType>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<PermitTypeDTO>(getPermitType);
        }

        public PermitTypeDTO newPermitType(PermitTypeDTO PermitType)
        {
            if (!uow.GetRepository<PermitType>().GetAll().Any(z => z.Id == PermitType.Id))
            {
                var adedPermitType = MapperFactory.CurrentMapper.Map<PermitType>(PermitType);
                adedPermitType = uow.GetRepository<PermitType>().Add(adedPermitType);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<PermitTypeDTO>(adedPermitType);
            }
            else
            {
                return null;
            }
        }

        public PermitTypeDTO updatePermitType(PermitTypeDTO PermitType)
        {
            var selectedPermitType = uow.GetRepository<PermitType>().Get(z => z.Id == PermitType.Id);
            selectedPermitType = MapperFactory.CurrentMapper.Map(PermitType, selectedPermitType);
            uow.GetRepository<PermitType>().Update(selectedPermitType);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<PermitTypeDTO>(selectedPermitType);
        }
    }
}
