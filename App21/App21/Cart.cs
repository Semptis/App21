using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    public class Cart
    {
        private List<(ProductBase product, int count)> products;
        public delegate void AddProductDelegate(ProductBase product, int count);
        public event AddProductDelegate AddProduct;
        public Cart()
        {
            this.products = new List<(ProductBase, int)>();
        }

        public void AddProductToCart(ProductBase product, int count)
        {
            if (count > 0)
            {
                products.Add((product, count));
                if (AddProduct != null)
                {
                    AddProduct(product, count);
                }
            }
            else
            {
                throw new Exception("The product count is incorrect");
            }
        }

        public float SummaryPriceFromCart()
        {
            var sum = 0f;
            foreach (var item in products)
            {
                sum += item.product.GetPrice() * item.count;
            }
            return sum;
        }
    }
}
