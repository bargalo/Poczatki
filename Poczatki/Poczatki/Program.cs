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
Console.WriteLine("Podaj imię pracownika:");
var name = Console.ReadLine();
Console.WriteLine("Podaj nazwisko pracownika:");
var surname = Console.ReadLine();
//var employeeInFile = new EmployeeInFile(name, surname);
var employeeInMemory = new EmployeeInMemory(name, surname);
var employeeInFile = new EmployeeInFile(name, surname);
//employee.AddGrade(0.5f);
//employeeInMemory.GradeAdded += EmployeeGradeAdded;

//void EmployeeGradeAdded(object sender, EventArgs args)
//{
//    Console.WriteLine("Dodano nową ocenę!");
//}

//var supervisor = new Supervisor();
Console.WriteLine("Podaj ocenę pracownika:");

while (true)
{
    employeeInMemory.GradeAdded += EmployeeGradeAdded;
    void EmployeeGradeAdded(object sender, EventArgs args)
    {
        Console.WriteLine("Dodano nową ocenę!");
    }
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employeeInFile.AddGrade(input);
        employeeInMemory.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    employeeInMemory.GradeAdded -= EmployeeGradeAdded;
    Console.WriteLine("Podaj kolejną ocenę pracownika...");
}
//Console.WriteLine("Podaj ocenę supervisor'a:");
//while (true)
//{
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }
//    try
//    {
//        supervisor.AddGrade(input);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    Console.WriteLine("Podaj kolejną ocenę supervisor'a...");
//}

Console.WriteLine("Oceny pracownika:");
Console.WriteLine("=================");
var stats = employeeInFile.GetStatistics();
Console.WriteLine($" Average: {stats.Average}");
Console.WriteLine($" Max: {stats.Max}");
Console.WriteLine($" Min: {stats.Min}");
Console.WriteLine($" Rating: {stats.AverageLetter}");
Console.WriteLine($" Count: {stats.Count}");
Console.WriteLine($" Sum: {stats.Sum}");
Console.WriteLine("|||||||||||||||||||||||||||||||");
//Console.WriteLine("Oceny supervisor'a:");
//Console.WriteLine("=================");
//var stats2 = supervisor.GetStatistics();
//Console.WriteLine($" Average: {stats2.Average}");
//Console.WriteLine($" Max: {stats2.Max}");
//Console.WriteLine($" Min: {stats2.Min}");
//Console.WriteLine($" Rating: {stats2.AverageLetter}");
