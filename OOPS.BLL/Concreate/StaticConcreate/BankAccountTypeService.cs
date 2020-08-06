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
    public class BankAccountTypeService : IBankAccountTypeService
    {
        private readonly IUnitofWork uow;
        public BankAccountTypeService(IUnitofWork uow)
        {
            this.uow = uow;
        }

        public bool deleteBankAccountTypeDTO(int BankAccountTypeId)
        {
            try
            {
                var getBankAccountType = uow.GetRepository<BankAccountType>().Get(z => z.Id == BankAccountTypeId);
                uow.GetRepository<BankAccountType>().Delete(getBankAccountType);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<BankAccountTypeDTO> getAll()
        {
            var getBankAccountTypeList = uow.GetRepository<BankAccountType>().Get(null, null, null).ToList();
            return MapperFactory.CurrentMapper.Map<List<BankAccountTypeDTO>>(getBankAccountTypeList);
        }

        public BankAccountTypeDTO getBankAccountType(int Id)
        {
            var getBankAccountType = uow.GetRepository<BankAccountType>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<BankAccountTypeDTO>(getBankAccountType);
        }

        public BankAccountTypeDTO newBankAccountType(BankAccountTypeDTO BankAccountType)
        {
            if (!uow.GetRepository<BankAccountType>().GetAll().Any(z => z.Id == BankAccountType.Id))
            {
                var adedBankAccountType = MapperFactory.CurrentMapper.Map<BankAccountType>(BankAccountType);
                adedBankAccountType = uow.GetRepository<BankAccountType>().Add(adedBankAccountType);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<BankAccountTypeDTO>(adedBankAccountType);
            }
            else
            {
                return null;
            }
        }

        public BankAccountTypeDTO updateBankAccountType(BankAccountTypeDTO BankAccountType)
        {
            var selectedBankAccountType = uow.GetRepository<BankAccountType>().Get(z => z.Id == BankAccountType.Id);
            selectedBankAccountType = MapperFactory.CurrentMapper.Map(BankAccountType, selectedBankAccountType);
            uow.GetRepository<BankAccountType>().Update(selectedBankAccountType);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<BankAccountTypeDTO>(selectedBankAccountType);
        }
    }
}
