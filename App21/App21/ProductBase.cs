using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    public abstract class ProductBase: IProduct
    {
        public ProductBase(string name, decimal price)
        {
            this.Name= name;
            this.Price= price;
        }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public abstract decimal GetPrice(float weightInGrams);
        public abstract decimal GetPrice();

    }
}
