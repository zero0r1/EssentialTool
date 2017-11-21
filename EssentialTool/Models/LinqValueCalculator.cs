using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTool.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        /// <summary>
        /// 计算Product 对象集合的总价
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price);
        }
    }
}