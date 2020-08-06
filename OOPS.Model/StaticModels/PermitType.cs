using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class PermitType : Entity<int>
    {
        public string PermitTypeName { get; set; }
    }
}
