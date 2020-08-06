using OOPS.BLL.Abstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.ProjectBase;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.ProjectBaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Concreate
{
    public class RoleService : IRoleService
    {

        private IUnitofWork uow;
        public RoleService(IUnitofWork _uow)
        {
            uow = _uow;
        }
        public bool CheckUserRole(int userId)
        {
            throw new NotImplementedException();
        }

        public RoleDTO GetById(int Id)
        {
            var getRole = uow.GetRepository<Role>()
                 .Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<RoleDTO>(getRole);
        }
    }
}
