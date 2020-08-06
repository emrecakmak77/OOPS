using OOPS.Core.Business;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.Employee
{
    public interface IDebitService : IServiceBase
    {
        List<DebitDTO> getAllEmployeeDebits();
        DebitDTO getDebit(int Id);
        DebitDTO newDebit(DebitDTO Debit);
        DebitDTO updateDebit(DebitDTO Debit);
        bool deleteDebit(int Id);
        List<DebitDTO> getEmployeeDebits(int employeeId);
    }
}
