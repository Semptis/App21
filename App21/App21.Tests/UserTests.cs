namespace App21.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserGetMinusPoints_ShouldCorrectResult()
        {
            var user = new Employee("Adam", "Kowalski", 22);
            user.AddScores(5);
            user.AddScores(6);
            user.AddScores(-7);

            var result = user.GetScore();

            Assert.AreEqual(4, result);


        }
    }
} 