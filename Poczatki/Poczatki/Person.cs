namespace Poczatki
{
    public abstract class Person
    {
        public Person(string name, string surname, char sex)
        {
            Name = name;
            Surname = surname;
            Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Sex { get; private set; } 
    }
}
