namespace Poczatki.Tests
{
    public class Typetests
    {
        //typ wartościowy
        [Test]
        public void TwoStringsAreEqualOrNot()
        {
            string name1 = "Bartek";
            string name2 = "Bartek";

            Assert.AreEqual(name1, name2);
        }
        //typ wartościowy
        [Test]
        public void TwoIntsAreEqualOrNot()
        {
            int number1 = 1;
            int number2 = 2;  

            Assert.AreNotEqual(number1, number2);
        }
        //typ wartościowy
        [Test]
        public void TwoFloatsAreEqualOrNot()
        {
            float number1 = 20.8F;
            float number2 = 25.7F;

            Assert.AreNotEqual(number1, number2);
        }
        //typ referencyjny
        [Test]
        public void GetUserValuesAreEqualOrNot()
        {
            var user1 = GetUser("Bartek");
            var user2 = GetUser("Bartek");

            Assert.AreNotEqual(user1, user2);
        }
        private Employee GetUser(string name)
        {
            return new Employee(name);
        }

        
    }
}
