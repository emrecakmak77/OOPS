using OOPS.Core.Business;
using OOPS.DTO.ProjectBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract
{
    public interface IRoleService : IServiceBase
    {
        RoleDTO GetById(int Id);
        bool CheckUserRole(int userId);
    }
}
