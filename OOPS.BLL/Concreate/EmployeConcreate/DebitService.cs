using OOPS.BLL.Abstract.Employee;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Employee;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate.EmployeeConcreate
{
    public class DebitService : IDebitService
    {
        private readonly IUnitofWork uow;

        public DebitService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteDebit(int Id)
        {
            try
            {
                var getDebit = uow.GetRepository<Debit>().Get(z => z.Id == Id);
                uow.GetRepository<Debit>().Delete(getDebit);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<DebitDTO> getAllEmployeeDebits()
        {
            var getDebitList = uow.GetRepository<EmployeeDebit>().Get(null, x => x.Debit.DebitCategory).Select(x => x.Debit).OrderByDescending(x => x.Id).ToList();
            return MapperFactory.CurrentMapper.Map<List<DebitDTO>>(getDebitList);
        }

        public DebitDTO getDebit(int Id)
        {
            var getDebit = uow.GetRepository<Debit>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<DebitDTO>(getDebit);
        }

        public List<DebitDTO> getEmployeeDebits(int employeeId)
        {
            var emp = uow.GetRepository<EmployeeDebit>().GetAll().Where(z => z.EmployeeId == employeeId).Select(x => x.Debit).ToList();
            return MapperFactory.CurrentMapper.Map<List<DebitDTO>>(emp);
        }

        public DebitDTO newDebit(DebitDTO Debit)
        {
            var adedDebit = MapperFactory.CurrentMapper.Map<Debit>(Debit);
            uow.GetRepository<Debit>().Add(adedDebit);
            uow.SaveChanges();
            var addedEmployeeDebit = new EmployeeDebit()
            {
                EmployeeId = Debit.EmployeeId,
                DebitId = adedDebit.Id
            };
            uow.GetRepository<EmployeeDebit>().Add(addedEmployeeDebit);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<DebitDTO>(adedDebit);
        }

        public DebitDTO updateDebit(DebitDTO Debit)
        {
            var selectedDebit = uow.GetRepository<Debit>().Get(z => z.Id == Debit.Id);
            selectedDebit = MapperFactory.CurrentMapper.Map(Debit, selectedDebit);
            uow.GetRepository<Debit>().Update(selectedDebit);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<DebitDTO>(selectedDebit);
        }
    }
}
