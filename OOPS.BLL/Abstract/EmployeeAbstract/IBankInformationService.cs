using OOPS.Core.Business;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.Employee
{
    public interface IBankInformationService : IServiceBase
    {
        BankInformationDTO getBankInformation(int Id);
        BankInformationDTO newBankInformation(BankInformationDTO bankInformation);
        BankInformationDTO updateBankInformation(BankInformationDTO bankInformation);
        bool deleteBankInformation(int bankInformationId);
    }
}