﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    /// <summary>
    /// Represents a Product in ECommerce application
    /// </summary>
    public class Product
    {
        //properties
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public DateTime DateOfManufacture { get; set; }

    }
}
