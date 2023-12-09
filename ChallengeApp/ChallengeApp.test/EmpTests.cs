namespace ChallengeApp.test
{
    public class EmpTests
    {
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnCorrectMax()
        {
            var employee = new Employee();
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(2);

            var statisctics = employee.GetStatistics();
            Assert.AreEqual(6, statisctics.Max);
        }

        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnCorrectMin()
        {
            var employee = new Employee();
            employee.AddGrade(12);
            employee.AddGrade(10);
            employee.AddGrade(14);
            
            
            var statisctics = employee.GetStatistics();
            Assert.AreEqual(10, statisctics.Min);
        }

        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnCorrectAverage()
        {
            var employee = new Employee();
            employee.AddGrade(12);
            employee.AddGrade(10);
            employee.AddGrade(8);
            
            
            var statisctics = employee.GetStatistics();
            Assert.AreEqual(10, statisctics.Average);
        }

        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnCorrectLetter()
        {
            var employee = new Employee();
            employee.AddGrade(50);
            employee.AddGrade(75);
            employee.AddGrade(95);
            employee.AddGrade("A");


            var statisctics = employee.GetStatistics();
            Assert.AreEqual('A', statisctics.AverageLetter);
        }
    }
}