using System.Drawing;

namespace App21.Tests
{
    public class ShopTests
    {
        [Test]
        public void WhenAddedProductToCart_ShouldCorrectTotal()
        {
            var apple = new Product("Apple", 3.90m);
            var magazine = new Magazine();
            var cart = new Cart();

            cart.AddProduct += magazine.RemoveProductFromStock;
            magazine.AddProductsToStock(apple, 50);
            cart.AddProductToCart(apple, 5);

            Assert.That(cart.FinishTransaction(), Is.EqualTo(19.50));
        }
        [Test]
        public void WhenAddedExpireProductToCart_ShouldCorrectTotal()
        {
            var apple = new ProductNearExpiryDate("Apple", 3.90m);
            var magazine = new Magazine();
            var cart = new Cart();

            cart.AddProduct += magazine.RemoveProductFromStock;
            magazine.AddProductsToStock(apple, 50);
            cart.AddProductToCart(apple, 5);

            Assert.That(cart.FinishTransaction(), Is.EqualTo(9.75));
        }
        [Test]
        public void WhenAddedMixProductToCart_ShouldCorrectTotal()
        {
            var apple = new ProductNearExpiryDate("Apple", 3.90m);
            var grape = new Product("Grape", 3.80m);
            var magazine = new Magazine();
            var cart = new Cart();

            cart.AddProduct += magazine.RemoveProductFromStock;
            magazine.AddProductsToStock(apple, 50);
            magazine.AddProductsToStock(grape, 50);
            cart.AddProductToCart(apple, 5);
            cart.AddProductToCart(grape, 5);

            Assert.That(cart.FinishTransaction(), Is.EqualTo(28.75));
        }
    }
} 