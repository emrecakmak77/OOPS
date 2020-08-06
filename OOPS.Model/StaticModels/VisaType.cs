using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class VisaType : Entity<int>
    {
        public string VisaTypeName { get; set; }
    }
}
