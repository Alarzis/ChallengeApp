/// 1. Stwórz klasę Employee, w której przechowasz imię, nazwisko, wiek
/// oraz punkty pracownika w postaci liczb całkowitych.
/// 
/// 2. Stwórz 3 pracowników i każdemu przydziel po 5 ocen z zakresu
/// od 1 do 10.
/// 
/// 3. Napisz program, który wyszuka pracownika z najwyższą liczbą ocen
/// a następnie wyświetli jego dane oraz wynik.
 


using ChallengeApp;

Employee employee1 = new Employee ("Andrzej", "Borkowski", "31");
Employee employee2 = new Employee ("Monika", "Misiak", "28");
Employee employee3 = new Employee ("Ewa", "Nawrot", "36");

employee1.AddScore(500);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);

employee2.AddScore(2);
employee2.AddScore(2);
employee2.AddScore(2);
employee2.AddScore(2);
employee2.AddScore(2);

employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (Employee employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
};

Console.WriteLine("W tym mięsiącu największą liczbę punktów, bo aż " + maxResult);
Console.WriteLine("zdobywa nie kto inny, a " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + ", lat " + employeeWithMaxResult.Age + ".");