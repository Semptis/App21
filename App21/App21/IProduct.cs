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
        abstract decimal GetPrice(float weightInGrams);
        abstract decimal GetPrice();
    }
}
