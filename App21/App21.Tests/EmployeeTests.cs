namespace App21.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenUserGetPoints_ShouldCorrectStatistics()
        {
            var emp = new Employee("Adam", "Kowalski", 22);
            emp.AddScores("A");
            emp.AddScores("B");

            var stat = emp.GetStatistics();

            Assert.AreEqual(100, stat.Max);
            Assert.AreEqual(75, stat.Min);
            Assert.AreEqual(87,5, stat.Avg);
            Assert.AreEqual("A", stat.AvgLetter);

        }
    }
} 