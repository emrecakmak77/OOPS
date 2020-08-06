using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.ProjectBaseModel
{
    public class Role : Entity<int>
    {
        public Role()
        {
            Users = new HashSet<User>();
        }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
