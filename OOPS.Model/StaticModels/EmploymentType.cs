using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class EmploymentType : Entity<int>
    {
        public string EmploymentTypeName { get; set; }
    }
}
