﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditional
{
    class ShoppingCart
    {
        public Customer Customer { get; set; }
        public string OrderId { get; set; }
        public List<Order> Orders { get; set; }
    }
}
