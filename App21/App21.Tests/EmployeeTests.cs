namespace App21.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeGetGrade_ShouldCorrectStatistics()
        {
            var emp = new Employee("Adam", "Kowalski",'M' ,22);
            emp.AddGrade("A");
            emp.AddGrade("B");

            var stat = emp.GetStatistics();

            Assert.AreEqual(100, stat.Max);
            Assert.AreEqual(75, stat.Min);
            Assert.AreEqual(87,5, stat.Avg);
            Assert.AreEqual("A", stat.AvgLetter);

        }
    }
} 