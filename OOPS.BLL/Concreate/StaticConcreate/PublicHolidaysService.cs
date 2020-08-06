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
   public class PublicHolidaysService : IPublicHolidaysService
    {
        private readonly IUnitofWork uow;
        public PublicHolidaysService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public List<PublicHolidaysDTO> getAll()
        {
            var getHolidaysList = uow.GetRepository<PublicHolidays>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<PublicHolidaysDTO>>(getHolidaysList);
        }
    }
}
