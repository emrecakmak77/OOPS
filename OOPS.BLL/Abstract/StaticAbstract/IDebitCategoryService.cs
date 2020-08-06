using OOPS.Core.Business;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.StaticAbstract
{
    public interface IDebitCategoryService : IServiceBase
    {
        List<DebitCategoryDTO> getAll();
        DebitCategoryDTO getDebitCategory(int Id);
        DebitCategoryDTO newDebitCategory(DebitCategoryDTO DebitCategory);
        DebitCategoryDTO updateDebitCategory(DebitCategoryDTO DebitCategory);
        bool deleteDebitCategoryDTO(int DebitCategoryId);
    }
}
