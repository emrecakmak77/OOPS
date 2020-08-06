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
    public class ActivityCalenderService : IActivityCalenderService
    {

        private readonly IUnitofWork uow;
        public ActivityCalenderService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public List<ActivityCalenderDTO> getAll()
        {
            var getActivityList = uow.GetRepository<ActivityCalender>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<ActivityCalenderDTO>>(getActivityList);
        }
    }
}
