namespace App21.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenUserGetPoints_ShouldCorrectMaxScore()
        {
            var emp = new Employee("Adam", "Kowalski", 22);
            emp.AddScores(5);
            emp.AddScores(6);
            emp.AddScores(7);

            var stat = emp.GetStatistics();

            Assert.AreEqual(7, stat.Max);

        }
        [Test]
        public void WhenUserGetPoints_ShouldCorrectMinScore()
        {
            var emp = new Employee("Adam", "Kowalski", 22);
            emp.AddScores(5);
            emp.AddScores(6);
            emp.AddScores(7);

            var stat = emp.GetStatistics();

            Assert.AreEqual(5, stat.Min);

        }
        [Test]
        public void WhenUserGetPoints_ShouldCorrectAvgScore()
        {
            var emp = new Employee("Adam", "Kowalski", 22);
            emp.AddScores(5);
            emp.AddScores(6);
            emp.AddScores(7);

            var stat = emp.GetStatistics();

            Assert.AreEqual(6, stat.Avg);

        }
    }
} 