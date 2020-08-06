using OOPS.BLL.Abstract.EmployeeAbstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Employee;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate.EmployeConcreate
{
    public class PaymentsService : IPaymentsService
    {
        private readonly IUnitofWork uow;
        public PaymentsService(IUnitofWork _uow)
        {
            uow = _uow;
        }

        public List<PaymentDTO> getAllEmployeePaymentsByCompanyId(int companyId)
        {
            var emp = uow.GetRepository<EmployeePayment>().GetAll().Where(z => z.Employee.CompanyID == companyId).Select(x => x.Payment).OrderByDescending(x => x.PaymentDate).ToList();
            return MapperFactory.CurrentMapper.Map<List<PaymentDTO>>(emp);
        }

        public PaymentDTO getPayment(int Id)
        {
            throw new NotImplementedException();
        }
        public List<PaymentDTO> getEmployeePayments(int employeeId)
        {
            var emp = uow.GetRepository<EmployeePayment>().GetAll().Where(z => z.EmployeeId == employeeId).Select(x => x.Payment).ToList();
            return MapperFactory.CurrentMapper.Map<List<PaymentDTO>>(emp);
        }
        public PaymentDTO newPayment(PaymentDTO Payment)
        {
            var addedPayment = MapperFactory.CurrentMapper.Map<Payment>(Payment);
            uow.GetRepository<Payment>().Add(addedPayment);
            uow.SaveChanges();
            var addedEmployeePayment = new EmployeePayment()
            {
                EmployeeId = Payment.EmployeeId,
                PaymentId = addedPayment.Id
            };
            uow.GetRepository<EmployeePayment>().Add(addedEmployeePayment);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<PaymentDTO>(addedPayment);
        }

        public PaymentDTO updatePayment(PaymentDTO Payment)
        {
            throw new NotImplementedException();
        }
    }
}
