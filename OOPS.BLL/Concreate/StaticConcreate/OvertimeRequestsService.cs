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
    public class OvertimeRequestsService : IOvertimeRequestsService
    {
        //private readonly IUnitofWork uow;
        //public OvertimeRequestsService(IUnitofWork uow)
        //{
        //    this.uow = uow;
        //}
        //public List<OvertimeRequestsDTO> getAll()
        //{
        //    var overtime = uow.GetRepository<OvertimeRequests>().GetAll().ToList();
        //    return MapperFactory.CurrentMapper.Map<List<OvertimeRequestsDTO>>(overtime);
        //}
    }
}
