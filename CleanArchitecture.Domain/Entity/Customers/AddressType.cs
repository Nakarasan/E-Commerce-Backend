﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Customers
{
    public class AddressType
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Type { get; set; }
        public bool IsActive { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
