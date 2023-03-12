using App21;
using System.Linq.Expressions;


var apple = new Product("Apple", 3.99f);
var grape = new ProductNearExpiryDate("Grape", 30);

var magazine = new Magazine();
var cart = new Cart();
cart.AddProduct += magazine.RemoveProductFromStock;

magazine.AddProductsToStock(apple, 50);
magazine.AddProductsToStock(grape, 50);

Console.WriteLine("Welcome");

while (true)
{
    try
    {
        Console.WriteLine("The following products are currently available in the store: ");
        magazine.ShowAcctualStockInMagazine();
        Console.WriteLine("Choose what do you want: ");
        var a = Console.ReadLine();
        switch (a)
        {
            case "Apple":
                Console.WriteLine("How many: ");
                var b = Console.ReadLine();
                cart.AddProductToCart(apple, Int32.Parse(b));
                break;
        }

        if (a == "q")
        {
            break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}




