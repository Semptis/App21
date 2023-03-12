using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    public class ProductNearExpiryDate : ProductBase
    {
        public ProductNearExpiryDate(string name, float price) :
            base(name, price)
        {
        }
        public override float GetPrice(float weightInGrams)
        {
            return ((weightInGrams / 100) * this.Price)/2;
        }
        public override float GetPrice()
        {
            return (this.Price)/2;
        }
    }
}
