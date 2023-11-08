namespace ChallengeApp.test
{
    public class TypeTests
    {
        [Test]
        public void WhenComparedTwoEmployees_ShouldNotBeEqual()
        {
            // arrange

            var employee1 = GetEmployee("Andrzej", "awdawd3245", "27");
            var employee2 = GetEmployee("Andrzej", "awdawd3245", "27");

            // act

            // assert

            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void WhenComparedTwoInt_ShouldNotBeEqual()
        {
            // arrange

            int digit1 = 1;
            int digit2 = 2;

            // act

            // assert

            Assert.AreNotEqual(digit1, digit2);
        }

        [Test]
        public void WhenComparedTwoInt_ShouldBeEqual()
        {
            // arrange

            int digit3 = 3;
            int digit4 = 3;

            // act

            // assert

            Assert.AreEqual(digit3, digit4);
        }

        [Test]
        public void WhenComparedTwoString_ShouldBeEqual()
        {
            // arrange
            string employee3 = "Andrzej";
            string employee4 = "Andrzej";

            // act

            // assert
            Assert.AreEqual(employee3, employee4);
        }

        private Employee GetEmployee(string name, string surname, string age)
        {
            return new Employee(name, surname, age);
        }
    }
}
