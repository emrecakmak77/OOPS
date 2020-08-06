using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.WebUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class UserDetailViewComponent : ViewComponent
    {
        private readonly IUserService userService;

        public UserDetailViewComponent(IUserService _userService)
        {
            userService = _userService;
        }

        public IViewComponentResult Invoke()
        {
            var userDTO = OOPSConvert.OOPSJsonDeSerializeUserDTO(HttpContext.User.Claims.FirstOrDefault(z => z.Type == "UserDTO").Value);
            return View(userDTO);
        }
    }
}
