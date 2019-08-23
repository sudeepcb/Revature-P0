﻿using System;
using System.Collections.Generic;

namespace PizzaDelivery.Data.Entities
{
    public partial class Crust
    {
        public Crust()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int CrustId { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
