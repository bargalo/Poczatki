using Poczatki;

namespace PoczatkiTests
{
    public class Tests
    {
        

     [Test]
        public void StatsMaxValueShouldBeEqual_6()
        {
            var employee = new Employee("Bartek", "Galant");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            var stats = employee.GetStatistics();
            Assert.AreEqual(6, stats.Max);
        }

        [Test]
        public void StatsMinValueShouldBeEqual_2()
        {
            var employee = new Employee("Bartek", "Galant");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
           
            var stats = employee.GetStatistics();
            Assert.AreEqual(2, stats.Min);
        }
        [Test]
        public void StatsAverageValueShouldBeEqual_3Point33()
        {
            var employee = new Employee("Bartek", "Galant");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            var stats = employee.GetStatistics();
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(stats.Average, 2));
        }
    }
}