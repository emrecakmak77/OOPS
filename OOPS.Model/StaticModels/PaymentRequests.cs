﻿using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class PaymentRequests : Entity<int>
    {
        public string Name { get; set; }
        public string DateTime { get; set; }
    }
}
