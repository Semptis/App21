using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    public class Product : ProductBase
    {
        public Product(string name, decimal price) :
            base(name, price)
        {
        }
        public override decimal GetPrice(float weightInGrams)
        {
            return (decimal)(weightInGrams / 100) * this.Price;
        }
        public override decimal GetPrice()
        {
            return this.Price;
        }
    }
}
