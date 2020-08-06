using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class City : Entity<int>
    {
        public City()
        {
            Districts = new HashSet<District>();
            EmployeeOtherInfos = new HashSet<EmployeeOtherInfo>();
        }

        public string Name { get; set; }
        public string Code { get; set; }

        [ForeignKey("Country")]
        public Nullable<int> CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<District> Districts { get; set; }
        public virtual ICollection<EmployeeOtherInfo> EmployeeOtherInfos { get; set; }
    }
}
