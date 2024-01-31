using ChallengeApp;
using System;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("=======================================");
Console.WriteLine();

var employee = new EmployeeInFile("Andrzej", "Borkowski");
//var supervisor = new Supervisor("Monika", "Misiak");

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

//Console.WriteLine("Podaj ocenę kierownika: ");
//while (true)
//{
//    var input = Console.ReadLine();
//    if (input == "Q" || input == "q")
//    {
//        break;
//    }

//    try
//    {
//        supervisor.AddGrade(input);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catched: {e.Message}");
//    }

//    Console.WriteLine("Podaj kolejną ocenę, lub wciśnij Q i zatwierdź, żeby zakończyć");
//}

var statisctics1 = employee.GetStatistics();
//var statisctics2 = supervisor.GetStatistics();

Console.WriteLine("Wyniki naszego pracownika");
Console.WriteLine($"Średnia z ocen: {statisctics1.Average:N2}");
Console.WriteLine($"Najlepsza ocena: {statisctics1.Max}");
Console.WriteLine($"Najsłabsza ocena: {statisctics1.Min}");
Console.WriteLine($"Ocena końcowa: {statisctics1.AverageLetter}");

//Console.WriteLine();

//Console.WriteLine("Wyniki naszego kierownika");
//Console.WriteLine($"Średnia z ocen: {statisctics2.Average:N2}");
//Console.WriteLine($"Najlepsza ocena: {statisctics2.Max}");
//Console.WriteLine($"Najsłabsza ocena: {statisctics2.Min}");
//Console.WriteLine($"Ocena końcowa: {statisctics2.AverageLetter}");