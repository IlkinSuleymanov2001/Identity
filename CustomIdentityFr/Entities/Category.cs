﻿using CustomIdentityFr.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.Entities
{
    public  class Category:BaseEntity<int>
    {
        public string Name { get; set; }    
        public string? Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
