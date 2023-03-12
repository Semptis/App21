using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    public class Product : ProductBase
    {
        public Product(string name, float price) :
            base(name, price)
        {
        }
        public override float GetPrice(float weightInGrams)
        {
            return (weightInGrams / 100) * this.Price;
        }
        public override float GetPrice()
        {
            return this.Price;
        }
    }
}
