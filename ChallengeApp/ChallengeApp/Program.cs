/// Napisz w Program.cs kod, w którym:
/// - zadeklarujesz zmienną z imieniem
/// - zadeklarujesz zmienną z płcią (dobierz zmienną)
/// - zadeklarujesz zmienną z wiekiem
/// - zweryfikujesz dane i wyświetlisz
/// jeden z komunikatów:
/// (1): "Kobieta poniżej 30 lat"
/// (2): "Ewa, lat 33"
/// (3): "Niepełnoletni Mężczyzna"
/// -----------------
/// (możesz dodać swoje)


string name = "Ewa";
int age = 33;
int gender = 1;

if (gender == 1)
{
    if age < 30
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else
    {
        Console.WriteLine("Kobieta powyżej 30 lat");
    }
}
else if (age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Dorosły mężczyzna");
}