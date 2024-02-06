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
        [Test]
        public void WhenSomeLetterAddgradeGiveCorrectStats()
        {
            var employee = new Employee("Bartek", "Galant");
            employee.AddGrade('A');
            employee.AddGrade(80);
            employee.AddGrade("80");
            employee.AddGrade('B');
            
            var stats = employee.GetStatistics();
            Assert.AreEqual(85, stats.Average);
            Assert.AreEqual(100, stats.Max);
            Assert.AreEqual(80, stats.Min);
            Assert.AreEqual('A', stats.AverageLetter);
        }
        [Test]
        public void WhenValuesInLettersAndDigitsAddgradeGiveCorrectStats()
        {
            var employee = new Employee("Bartek", "Galant");
            employee.AddGrade('A');
            employee.AddGrade(70);
            employee.AddGrade('D');
            employee.AddGrade(98);

            var stats = employee.GetStatistics();
            Assert.AreEqual(77, stats.Average);
            Assert.AreEqual(100, stats.Max);
            Assert.AreEqual(40, stats.Min);
            Assert.AreEqual('B', stats.AverageLetter);
        }
    }
}