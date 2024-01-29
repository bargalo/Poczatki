using Poczatki;

Employee user1 = new Employee("Arek", "Sobczak", 26);
Employee user2 = new Employee("Wacek", "Lepczynski", 52);
Employee user3 = new Employee("Ania", "Kowalczyk", 38);



user1.AddScore(2);
user1.AddScore(7);
user1.AddScore(3);
user1.AddScore(1);
user1.AddScore(1);

user2.AddScore(1);
user2.AddScore(2);
user2.AddScore(3);
user2.AddScore(1);
user2.AddScore(3);

user3.AddScore(5);
user3.AddScore(2);
user3.AddScore(4);
user3.AddScore(4);
user3.AddScore(6);

List<Employee> employees = new List<Employee>()
{
    user1 ,user2, user3
};

int maxResult = -1;
Employee userWithTopScore = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        userWithTopScore = employee;
    }
}
Console.WriteLine("Pracownik z najwiekszą ilością punktów to =>" + " " + userWithTopScore.Name + " " + userWithTopScore.Surname + " " + userWithTopScore.Age + "lat" + " " + userWithTopScore.Result + "pkt");






