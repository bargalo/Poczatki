using Poczatki;

var employee = new Employee("Bartek", "Galant");
employee.AddGrade(2);
employee.AddGrade(20000);
employee.AddGrade("Bartek");
employee.AddGrade(8);
var stats = employee.GetStatistics();
Console.WriteLine($"Average: {stats.Average:N2}");
Console.WriteLine("Min: " + stats.Min);
Console.WriteLine($"Max: {stats.Max}");
