using System.Drawing;

namespace App21.Tests
{
    public class BookTests
    {
        [Test]
        public void WhenAddedGradeToBookInFile_ShouldCorrectStatistics()
        {
            var book = new BookInFile("DziadyTest1");

            var resultBefore = book.GetStatistics();
            book.AddGrade(5);
            book.AddGrade(5.5f);
            book.AddGrade("7,5");
            var resultAfter = book.GetStatistics();

            Assert.AreEqual(resultBefore.Count + 3, resultAfter.Count);
            Assert.AreEqual(resultBefore.Sum + 18f, resultAfter.Sum);
            Assert.AreEqual(7.5f, resultAfter.Max);
            Assert.AreEqual(5, resultAfter.Min);
            Assert.AreEqual(6, resultAfter.Avg);
        }

        [Test]
        public void WhenAddedGradeToBookInMemory_ShouldCorrectStatistics()
        {

            var book = new BookInMemory("DziadyTest2");

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