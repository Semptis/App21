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
        private List<(ProductBase product, int count)> productsInShop;
        public Magazine()
        {
            this.productsInShop = new List<(ProductBase, int)>();
        }
        public void AddProductsToStock(ProductBase product, int count)
        {
            if (count >= 0)
            {
                this.productsInShop.Add((product, count));
            }
            else
            {
                throw new Exception("The product count is incorrect");
            }
        }
        public void RemoveProductFromStock(ProductBase product, int count)
        {
            for (var i = 0; i < this.productsInShop.Count; i++)
            {
                if (productsInShop[i].product.Name == product.Name)
                {
                    var x = productsInShop[i];
                    x.count -= count;
                    productsInShop[i] = x;
                }
            }
        }
        public void ShowAcctualStock()
        {
            foreach (var product in this.productsInShop)
            {
                Console.WriteLine($"Name: {product.product.Name} Count: {product.count}");
            }
        }
    }
}
