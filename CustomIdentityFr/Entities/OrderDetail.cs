﻿using CustomIdentityFr.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.Entities
{
    public  class OrderDetail:BaseEntity<int >
    {
        public int  ProductId { get; set; }
        public int  OrderId { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
