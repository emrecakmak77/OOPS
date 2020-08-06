using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.ProjectBase
{
    public class RoleDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UserDTO> Users { get; set; }

    }
}
