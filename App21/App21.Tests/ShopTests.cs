using System.Drawing;

namespace App21.Tests
{
    public class ShopTests
    {
        [Test]
        public void WhenAddedGradeToBookInMemory_ShouldCorrectStatistics()
        {
            
            var book = new BookInFile("Dziady");

            book.AddGrade(5);
            book.AddGrade(5.5f);
            book.AddGrade("7,5");
            var result = book.GetStatistics();

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(18f, result.Sum);
            Assert.AreEqual(7.5f, result.Max);
            Assert.AreEqual(5, result.Min);
            Assert.AreEqual(6, result.Avg);
        }
        [Test]
        public void WhenAddedGradeToBookInFile_ShouldCorrectStatistics()
        {

            var book = new BookInMemory("Dziady");

            book.AddGrade(5);
            book.AddGrade(5.5f);
            book.AddGrade("7,5");
            var result = book.GetStatistics();

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(18f, result.Sum);
            Assert.AreEqual(7.5f, result.Max);
            Assert.AreEqual(5, result.Min);
            Assert.AreEqual(6, result.Avg);
        }
        }
}