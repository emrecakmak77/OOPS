using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Static;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate.StaticConcreate
{
    public class DebitCategoryService : IDebitCategoryService
    {
        private readonly IUnitofWork uow;
        public DebitCategoryService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteDebitCategoryDTO(int DebitCategoryId)
        {
            try
            {
                var getDebitCategory = uow.GetRepository<DebitCategory>().Get(z => z.Id == DebitCategoryId);
                uow.GetRepository<DebitCategory>().Delete(getDebitCategory);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<DebitCategoryDTO> getAll()
        {
            var getDebitCategoryList = uow.GetRepository<DebitCategory>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<DebitCategoryDTO>>(getDebitCategoryList);
        }

        public DebitCategoryDTO getDebitCategory(int Id)
        {
            var getDebitCategory = uow.GetRepository<DebitCategory>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<DebitCategoryDTO>(getDebitCategory);
        }

        public DebitCategoryDTO newDebitCategory(DebitCategoryDTO DebitCategory)
        {
            if (!uow.GetRepository<DebitCategory>().GetAll().Any(z => z.Id == DebitCategory.Id))
            {
                var adedDebitCategory = MapperFactory.CurrentMapper.Map<DebitCategory>(DebitCategory);
                adedDebitCategory = uow.GetRepository<DebitCategory>().Add(adedDebitCategory);
                uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<DebitCategoryDTO>(adedDebitCategory);
            }
            else
            {
                return null;
            }
        }

        public DebitCategoryDTO updateDebitCategory(DebitCategoryDTO DebitCategory)
        {
            var selectedDebitCategory = uow.GetRepository<DebitCategory>().Get(z => z.Id == DebitCategory.Id);
            selectedDebitCategory = MapperFactory.CurrentMapper.Map(DebitCategory, selectedDebitCategory);
            uow.GetRepository<DebitCategory>().Update(selectedDebitCategory);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<DebitCategoryDTO>(selectedDebitCategory);
        }
    }
}
