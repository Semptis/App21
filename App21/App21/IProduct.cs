using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    public interface IProduct
    {
        string Name { get; }
        abstract float GetPrice(float weightInGrams);
        abstract float GetPrice();
    }
}
