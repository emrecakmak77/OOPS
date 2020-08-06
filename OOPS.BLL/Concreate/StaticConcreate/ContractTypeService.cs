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
    public class ContractTypeService : IContractTypeService
    {
        private readonly IUnitofWork uow;
        public ContractTypeService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteContractTypeDTO(int ContractTypeId)
        {
            try
            {
                var getContractType = uow.GetRepository<ContractType>().Get(z => z.Id == ContractTypeId);
                uow.GetRepository<ContractType>().Delete(getContractType);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ContractTypeDTO> getAll()
        {
            var getContractTypeList = uow.GetRepository<ContractType>().Get(null, null, null).ToList();
            return MapperFactory.CurrentMapper.Map<List<ContractTypeDTO>>(getContractTypeList);
        }

        public ContractTypeDTO getContractType(int Id)
        {
            var getContractType = uow.GetRepository<ContractType>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<ContractTypeDTO>(getContractType);
        }

        public ContractTypeDTO newContractType(ContractTypeDTO ContractType)
        {
            if (!uow.GetRepository<ContractType>().GetAll().Any(z => z.Id == ContractType.Id))
            {
                var adedContractType = MapperFactory.CurrentMapper.Map<ContractType>(ContractType);
                adedContractType = uow.GetRepository<ContractType>().Add(adedContractType);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<ContractTypeDTO>(adedContractType);
            }
            else
            {
                return null;
            }
        }

        public ContractTypeDTO updateContractType(ContractTypeDTO ContractType)
        {
            var selectedContractType = uow.GetRepository<ContractType>().Get(z => z.Id == ContractType.Id);
            selectedContractType = MapperFactory.CurrentMapper.Map(ContractType, selectedContractType);
            uow.GetRepository<ContractType>().Update(selectedContractType);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<ContractTypeDTO>(selectedContractType);
        }
    }
}
