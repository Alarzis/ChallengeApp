using ChallengeApp;

var employee = new Employee("Andrzej", "Borkowski");
employee.AddGrade(10);
employee.AddGrade(45);
employee.AddGrade(65);
var statistics = employee.GetStatistics();
Console.WriteLine($"Najlepsza ocena: {statistics.Max}");
Console.WriteLine($"Najgorsza ocena: {statistics.Min}");
Console.WriteLine($"Średnia z ocen: {statistics.Average:N2}");
