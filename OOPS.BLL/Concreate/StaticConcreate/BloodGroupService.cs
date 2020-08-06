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
    public class BloodGroupService : IBloodGroupService
    {
        private readonly IUnitofWork uow;
        public BloodGroupService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteBloodGroupDTO(int BloodGroupId)
        {
            try
            {
                var getBloodGroup = uow.GetRepository<BloodGroup>().Get(z => z.Id == BloodGroupId);
                uow.GetRepository<BloodGroup>().Delete(getBloodGroup);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<BloodGroupDTO> getAll()
        {
            var getBloodGroupList = uow.GetRepository<BloodGroup>().Get(null, null, null).ToList();
            return MapperFactory.CurrentMapper.Map<List<BloodGroupDTO>>(getBloodGroupList);
        }

        public BloodGroupDTO getBloodGroup(int Id)
        {
            var getBloodGroup = uow.GetRepository<BloodGroup>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<BloodGroupDTO>(getBloodGroup);
        }

        public BloodGroupDTO newBloodGroup(BloodGroupDTO BloodGroup)
        {
            if (!uow.GetRepository<BloodGroup>().GetAll().Any(z => z.Id == BloodGroup.Id))
            {
                var adedBloodGroup = MapperFactory.CurrentMapper.Map<BloodGroup>(BloodGroup);
                adedBloodGroup = uow.GetRepository<BloodGroup>().Add(adedBloodGroup);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<BloodGroupDTO>(adedBloodGroup);
            }
            else
            {
                return null;
            }
        }

        public BloodGroupDTO updateBloodGroup(BloodGroupDTO BloodGroup)
        {
            var selectedBloodGroup = uow.GetRepository<BloodGroup>().Get(z => z.Id == BloodGroup.Id);
            selectedBloodGroup = MapperFactory.CurrentMapper.Map(BloodGroup, selectedBloodGroup);
            uow.GetRepository<BloodGroup>().Update(selectedBloodGroup);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<BloodGroupDTO>(selectedBloodGroup);
        }
    }
}
