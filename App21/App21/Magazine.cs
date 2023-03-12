using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    public class Magazine
    {
        private List<(ProductBase product, int count)> productsInMagazine;
        public Magazine()
        {
            this.productsInMagazine = new List<(ProductBase, int)>();
        }
        public void AddProductsToStock(ProductBase product, int count)
        {
            if (count >= 0)
            {
                this.productsInMagazine.Add((product, count));
            }
            else
            {
                throw new Exception("The product count is incorrect");
            }
        }
        public void RemoveProductFromStock(ProductBase product, int count)
        {
            for (var i = 0; i < this.productsInMagazine.Count; i++)
            {
                if (productsInMagazine[i].product.Name == product.Name)
                {
                    if (productsInMagazine[i].count >= count)
                    {
                        var x = productsInMagazine[i];
                        x.count -= count;
                        productsInMagazine[i] = x;
                    }
                    else
                    {
                        throw new Exception($"Insufficient amount of {product.Name} in the warehouse.");
                    }
                }
            }
        }
        public void ShowAcctualStockInMagazine()
        {
            foreach (var product in this.productsInMagazine)
            {
                Console.WriteLine($"Product name: {product.product.Name} Count: {product.count}");
            }
        }
    }
}
