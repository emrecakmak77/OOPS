using Microsoft.AspNetCore.Mvc;
using OOPS.DTO.ProjectBase;
using OOPS.WebUI.Core;
using System.Linq;

namespace OOPS.WebUI.Controllers
{
    public class BaseController : Controller
    {
        public UserDTO CurrentUser
        {
            get
            {
                var userDTO = HttpContext.User.Claims.FirstOrDefault(z => z.Type == "UserDTO").Value;
                return OOPSConvert.OOPSJsonDeSerializeUserDTO(userDTO);
            }
        }
    }
}
