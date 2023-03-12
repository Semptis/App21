using App21;
using System.Linq.Expressions;


var apple = new Product("Apple", 3.99f);
var grape = new ProductNearExpiryDate("Grape", 30);

var magazine = new Magazine();
magazine.AddProductsToStock(apple, 15);
magazine.AddProductsToStock(grape, 20);



try
{
    magazine.ShowAcctualStock();
    magazine.RemoveProductFromStock(apple, 5);
    magazine.ShowAcctualStock();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




