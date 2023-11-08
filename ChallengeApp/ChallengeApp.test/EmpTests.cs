namespace ChallengeApp.test
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectTwoScores_ShouldCorrectResult1()
        {
            //arrange
            var employee = new Employee("Andrzej", "awdawd3245", "24");
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(7);
            employee.AddScore(7);
            employee.AddScore(7);

            //act
            int result = employee.Result;

           //assert
           Assert.AreEqual(32, result);
        }

        [Test]
        public void WhenEmployeeCollectTwoScores_ShouldCorrectResult2()
        {
            //arrange
            var employee = new Employee("Monika", "awdawd3245", "27");
            employee.AddScore(-5);
            employee.AddScore(-6);
            employee.AddScore(-7);
            employee.AddScore(-8);
            employee.AddScore(-9);

            //act
            int result = employee.Result;

            //assert
            Assert.AreEqual(-35, result);
        }
    }
}