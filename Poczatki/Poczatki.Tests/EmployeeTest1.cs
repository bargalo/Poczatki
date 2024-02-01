namespace Poczatki.Tests
{
    public class Tests
    {
        [Test]
        public void CollectTwoScoresAsASum()
        {
            var user = new Employee("Bartek");//,"Kowalski",33);
            user.AddScore(5);
            user.AddScore(-2);

            var result = user.Result;

            Assert.AreEqual(3, result);     
        }
    }
}