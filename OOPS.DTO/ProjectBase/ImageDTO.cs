using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OOPS.DTO.ProjectBase
{
   public class ImageDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }

        [MaxLength]
        public byte[] ImageData { get; set; }
        public List<UserDTO> Users { get; set; }
        public List<EmployeeDTO> Employees { get; set; }
    }
}
