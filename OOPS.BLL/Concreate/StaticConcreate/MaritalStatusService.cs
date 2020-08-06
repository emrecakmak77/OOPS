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
    public class MaritalStatusService : IMaritalStatusService
    {
        private readonly IUnitofWork uow;
        public MaritalStatusService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteMaritalStatusDTO(int MaritalStatusId)
        {
            try
            {
                var getMaritalStatus = uow.GetRepository<MaritalStatus>().Get(z => z.Id == MaritalStatusId);
                uow.GetRepository<MaritalStatus>().Delete(getMaritalStatus);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<MaritalStatusDTO> getAll()
        {
            var getMaritalStatusList = uow.GetRepository<MaritalStatus>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<MaritalStatusDTO>>(getMaritalStatusList);
        }

        public MaritalStatusDTO getMaritalStatus(int Id)
        {
            var getMaritalStatus = uow.GetRepository<MaritalStatus>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<MaritalStatusDTO>(getMaritalStatus);
        }

        public MaritalStatusDTO newMaritalStatus(MaritalStatusDTO MaritalStatus)
        {
            if (!uow.GetRepository<MaritalStatus>().GetAll().Any(z => z.Id == MaritalStatus.Id))
            {
                var adedMaritalStatus = MapperFactory.CurrentMapper.Map<MaritalStatus>(MaritalStatus);
                adedMaritalStatus = uow.GetRepository<MaritalStatus>().Add(adedMaritalStatus);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<MaritalStatusDTO>(adedMaritalStatus);
            }
            else
            {
                return null;
            }
        }

        public MaritalStatusDTO updateMaritalStatus(MaritalStatusDTO MaritalStatus)
        {
            var selectedMaritalStatus = uow.GetRepository<MaritalStatus>().Get(z => z.Id == MaritalStatus.Id);
            selectedMaritalStatus = MapperFactory.CurrentMapper.Map(MaritalStatus, selectedMaritalStatus);
            uow.GetRepository<MaritalStatus>().Update(selectedMaritalStatus);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<MaritalStatusDTO>(selectedMaritalStatus);
        }
    }
}
