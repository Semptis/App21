namespace App21.Tests
{
    internal class TypeTests
    {
        [Test]
        public void WhenCompareTwoInt_ShouldTypeBeTheSame()
        {
            int num1 = 2;
            int num2 = 2;
            Assert.AreEqual(num1, num2);

        }

        [Test]
        public void WhenCompareTwoFloat_ShouldTypeBeTheSame()
        {
            float num1 = 2.2f;
            float num2 = 2.2f;
            Assert.AreEqual(num1, num2);

        }

        [Test]
        public void WhenCompareTwoString_ShouldTypeBeTheSame()
        {
            string num1 = "AAA";
            string num2 = "AAA";
            Assert.AreEqual(num1, num2);

        }

        [Test]
        public void WhenCompareTwoEmployees_ShouldTypeBeTheSame()
        {
            var emp = new Employee("Adam", "Kowalski", 22);
            var emp2 = new Employee("Adam", "Kowalski", 22);

            Assert.AreEqual(emp.GetPersonalData(),emp2.GetPersonalData());

        }


    }
}
