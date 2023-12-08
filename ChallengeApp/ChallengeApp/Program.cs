using ChallengeApp;

var employee = new Employee("Andrzej", "Borkowski");
employee.AddGrade("Andrzej");
employee.AddGrade("123123123");
employee.AddGrade(45);
employee.AddGrade(75);
var statistics1 = employee.GetStatisticsWithFor();
var statistics2 = employee.GetStatisticsWithForEach();
var statistics3 = employee.GetStatisticsWithWhile();
var statistics4 = employee.GetStatisticsWithDoWhile();

Console.WriteLine("Pętla For");
Console.WriteLine($"Najlepsza ocena: {statistics1.Max}");
Console.WriteLine($"Najgorsza ocena: {statistics1.Min}");
Console.WriteLine($"Średnia z ocen: {statistics1.Average:N2}");

Console.WriteLine("Pętla For each");
Console.WriteLine($"Najlepsza ocena: {statistics2.Max}");
Console.WriteLine($"Najgorsza ocena: {statistics2.Min}");
Console.WriteLine($"Średnia z ocen: {statistics2.Average:N2}");

Console.WriteLine("Pętla While");
Console.WriteLine($"Najlepsza ocena: {statistics3.Max}");
Console.WriteLine($"Najgorsza ocena: {statistics3.Min}");
Console.WriteLine($"Średnia z ocen: {statistics3.Average:N2}");

Console.WriteLine("Pętla Do While");
Console.WriteLine($"Najlepsza ocena: {statistics4.Max}");
Console.WriteLine($"Najgorsza ocena: {statistics4.Min}");
Console.WriteLine($"Średnia z ocen: {statistics4.Average:N2}");
