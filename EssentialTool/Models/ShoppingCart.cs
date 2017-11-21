using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTool.Models
{
    public class ShoppingCart
    {
        IValueCalculator calc;

        public ShoppingCart(IValueCalculator calcParam)
        {
            calc = calcParam;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}