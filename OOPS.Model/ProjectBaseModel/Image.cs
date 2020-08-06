using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OOPS.Model.ProjectBaseModel
{
    public class Image : Entity<int>
    {
        public Image()
        {
            Users = new HashSet<User>();
            Employees = new HashSet<Employee>();
        }

        public string Name { get; set; }
        public int Size { get; set; }

        [MaxLength]
        public byte[] ImageData { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

    }
}
