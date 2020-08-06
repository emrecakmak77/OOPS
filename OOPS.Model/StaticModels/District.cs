using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class District : Entity<int>
    {
        public District()
        {
            EmployeeOtherInfos = new HashSet<EmployeeOtherInfo>();
        }
        public string Name { get; set; }
        public string Code { get; set; }

        [ForeignKey("City")]
        public Nullable<int> CityId { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<EmployeeOtherInfo> EmployeeOtherInfos { get; set; }

    }
}
