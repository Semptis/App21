using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    public abstract class ProductBase: IProduct
    {
        public ProductBase(string name, float price)
        {
            this.Name= name;
            this.Price= price;
        }
        public string Name { get; private set; }
        public float Price { get; private set; }
        public abstract float GetPrice(float weightInGrams);
        public abstract float GetPrice();

    }
}
