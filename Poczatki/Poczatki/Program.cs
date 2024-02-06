using Poczatki;

//var employee = new Employee("Bartek", "Galant");
//employee.AddGrade(2);
//employee.AddGrade(20000);
//employee.AddGrade("Bartek");
//employee.AddGrade(38);
//employee.AddGrade('A');
//var stats = employee.GetStatistics();
//Console.WriteLine($"Average: {stats.Average:N2}");
//Console.WriteLine("Min: " + stats.Min);
//Console.WriteLine($"Max: {stats.Max}");
//Console.WriteLine(stats.AverageLetter);

Console.WriteLine("Witamy w programie WYZYSK przeznaczonym do oceny pracowników");
Console.WriteLine("============================================================");
Console.WriteLine();
Console.WriteLine("Podaj imię pracownika...");
var name = Console.ReadLine();
Console.WriteLine("Podaj nazwisko pracownika...");
var surname = Console.ReadLine();
var employee = new Employee(name, surname);
Console.WriteLine("Podaj ocenę pracownika");

while (true)
{
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    if (char.TryParse(input, out var value))
    {
        employee.AddGrade(value);
    }
    else 
    {
        employee.AddGrade(input);
        Console.WriteLine("Podaj kolejną ocenę pracownika:");
    } 
}
var stats = employee.GetStatistics();
Console.WriteLine($" Average: {stats.Average}");
Console.WriteLine($" Max: {stats.Max}");
Console.WriteLine($" Min: {stats.Min}");
Console.WriteLine($" Rating: {stats.AverageLetter}");
