using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class Country : Entity<int>
    {
        public Country()
        {
            EmployeeOtherInfos = new HashSet<EmployeeOtherInfo>();
            Cities = new HashSet<City>();
        }

        public string CountryName { get; set; }
        public string LangCode { get; set; }
        public string Code { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<EmployeeOtherInfo> EmployeeOtherInfos { get; set; }
    }
}
