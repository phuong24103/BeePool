﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class Brand
    {
        public Guid Id{ get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product>? Products { get; set; }

    }
}
