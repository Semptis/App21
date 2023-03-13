using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace App21
{
    public class Cart
    {
        private const string filePath = "history.txt";
        private List<(ProductBase product, int count)> products;
        public delegate bool AddProductDelegate(ProductBase product, int count);
        public event AddProductDelegate AddProduct;
        public Cart()
        {
            this.products = new List<(ProductBase, int)>();
        }

        public void AddProductToCart(ProductBase product, int count)
        {
            if (count > 0)
            {
                if (AddProduct != null)
                {
                    bool enoughProductsInMagazine = AddProduct(product, count);
                    if (enoughProductsInMagazine)
                    {
                        products.Add((product, count));
                    }
                }
            }
            else
            {
                throw new Exception("The product count is incorrect");
            }
        }

        public decimal FinishTransaction()
        {
            var sum = 0m;
            var result = "";
            foreach (var item in this.products)
            {
                sum += item.product.GetPrice() * item.count;
                result += $" Product: {item.product.Name} Price: {item.product.Price} Count: {item.count} \n";
            }

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                result += $" Total: {sum}zł";
                writer.Write(result);
            }

            return sum;
        }
    }
}
