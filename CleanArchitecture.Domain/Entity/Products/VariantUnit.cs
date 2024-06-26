﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Products
{
    public class VariantUnit
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Amount { get; set; }
        public bool IsActive { get; set; }

        public UnitType UnitType { get; set; }
    }
}
