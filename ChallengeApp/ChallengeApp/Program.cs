using ChallengeApp;
using System;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("=======================================");
Console.WriteLine();

var employee = new Employee("Andrzej", "Borkowski");

Console.WriteLine("Podaj ocenę pracownika: ");
while (true)
{
    var input = Console.ReadLine();
    if (input == "Q" || input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }

    Console.WriteLine("Podaj kolejną ocenę, lub wciśnij Q i zatwierdź, żeby zakończyć");
}

var statisctics = employee.GetStatistics();
Console.WriteLine($"Średnia z ocen: {statisctics.Average}");
Console.WriteLine($"Najlepsza ocena: {statisctics.Min}");
Console.WriteLine($"Najsłabsza ocena: {statisctics.Max}");
Console.WriteLine($"Ocena końcowa: {statisctics.AverageLetter}");