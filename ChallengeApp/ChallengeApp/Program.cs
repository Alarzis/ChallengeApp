using ChallengeApp;

var employee = new Employee("Andrzej", "Borkowski");
employee.AddGrade("Andrzej");
employee.AddGrade("123123123");
employee.AddGrade(45);
employee.AddGrade(75);
var statistics = employee.GetStatistics();
Console.WriteLine($"Najlepsza ocena: {statistics.Max}");
Console.WriteLine($"Najgorsza ocena: {statistics.Min}");
Console.WriteLine($"Średnia z ocen: {statistics.Average:N2}");