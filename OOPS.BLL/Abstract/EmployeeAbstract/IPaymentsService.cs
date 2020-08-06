using OOPS.Core.Business;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.EmployeeAbstract
{
    public interface IPaymentsService : IServiceBase
    {
        PaymentDTO getPayment(int Id);
        List<PaymentDTO> getAllEmployeePaymentsByCompanyId(int companyId);
        PaymentDTO newPayment(PaymentDTO Payment);
        PaymentDTO updatePayment(PaymentDTO Payment);
        List<PaymentDTO> getEmployeePayments(int employeeId);

    }
}
