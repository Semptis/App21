namespace App21.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenUserGetMinusPoints_ShouldCorrectResult()
        {
            var emp = new Employee("Adam", "Kowalski", 22);
            emp.AddScores(5);
            emp.AddScores(6);
            emp.AddScores(-7);

            var result = emp.GetScore();

            Assert.AreEqual(4, result);


        }
    }
} 