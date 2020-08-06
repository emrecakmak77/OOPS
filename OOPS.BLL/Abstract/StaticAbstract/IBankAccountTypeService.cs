using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IBankAccountTypeService : IServiceBase
    {
        List<BankAccountTypeDTO> getAll();
        BankAccountTypeDTO getBankAccountType(int Id);
        BankAccountTypeDTO newBankAccountType(BankAccountTypeDTO BankAccountType);
        BankAccountTypeDTO updateBankAccountType(BankAccountTypeDTO BankAccountType);
        bool deleteBankAccountTypeDTO(int BankAccountTypeId);
    }
}
