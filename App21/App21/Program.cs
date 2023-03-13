using App21;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq.Expressions;


var apple = new Product("Apple", 3.90m);
var grape = new ProductNearExpiryDate("Grape", 4.50m);
var tomato = new Product("Tomato", 2.49m);
var magazine = new Magazine();
var cart = new Cart();

cart.AddProduct += magazine.RemoveProductFromStock;

magazine.AddProductsToStock(apple, 50);
magazine.AddProductsToStock(grape, 50);
magazine.AddProductsToStock(tomato, 50);

Console.WriteLine("Welcome");

int myInt = 0;
while (true)
{
    try
    {
        var products = magazine.ShowAcctualProduktsInMagazine();
        Console.WriteLine($"The following products are currently available in the store: \n {products}");
        Console.WriteLine("Choose what do you want or type 'Exit' to finish transaction: ");
        var inputProdcut = Console.ReadLine();
        if (inputProdcut == "Exit" || inputProdcut == "exit")
        {
            var sum = cart.FinishTransaction();
            Console.WriteLine($"Total: {sum}");
            break;
        }
        Console.WriteLine("How many: ");
        var inputCount = Console.ReadLine();
        if (int.TryParse(inputCount, out myInt))
        {
            switch (inputProdcut)
            {
                case "Apple":
                case "apple":
                    cart.AddProductToCart(apple, myInt);
                    break;
                case "Grape":
                case "grape":
                    cart.AddProductToCart(grape, myInt);
                    break;
                case "Tomato":
                case "tomato":
                    cart.AddProductToCart(tomato, myInt);
                    break;
                default:
                    Console.WriteLine("Product inavailable");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Count must be integer");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}



