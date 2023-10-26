/// Przygotuj program, który policzy ile jakich cyfr
/// występuje w podanej liczbie
/// 
/// Przykład:
/// Wyniki dla liczby: 4566
/// 0 => 0
/// 1 => 0
/// 2 => 0
/// 3 => 0
/// 4 => 1
/// 5 => 1
/// 6 => 2
/// 7 => 0
/// 8 => 0
/// 9 => 0
///int number = 4566;
///string numberAsString = number.ToString();
///char[] letters = numberAsString.ToArray();


int number = 4566;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();
int[] counter = new int[10];
char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

Console.WriteLine("Poniżej wyświetlona jest ilość wystąpienia każdej cyfry w liczbie " + number + ":");

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < letters.Length; j++)
    {
        if (letters[j] == numbers[i])
            counter[i]++;
    }
    Console.WriteLine(numbers[i] + "=>" + counter[i]);
}