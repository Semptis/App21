using App21;
using System.Drawing;
using System.Linq.Expressions;


var apple = new Product("Apple", 3.99f);
var grape = new ProductNearExpiryDate("Grape", 30);
var tomato = new Product("Tomato", 15);

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
        Console.WriteLine($"The following products are currently available in the store: {products}");
        Console.WriteLine("Choose what do you want or type Exit to finish: ");
        var a = Console.ReadLine();
        if (a == "Exit")
        {
            var sum = cart.CartSummaryPrice();
            Console.WriteLine(sum);
            break;
        }
        Console.WriteLine("How many: ");
        var b = Console.ReadLine();
        if (int.TryParse(b, out myInt))
        {
            switch (a)
            {
                case "Apple":
                    cart.AddProductToCart(apple, myInt);
                    break;
                case "Grape":
                    cart.AddProductToCart(grape, myInt);
                    break;
                case "Tomato":
                    cart.AddProductToCart(tomato, myInt);
                    break;
                default:
                    Console.WriteLine("Wrong product");
                    break;
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}



