/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

Console.Write("Введите число: ");
string num = Console.ReadLine();
Console.WriteLine($"Сумма всех цифр в числе: {SumNum(num)}");
Console.WriteLine();

int SumNum(string number)
{
    int sum = 0;
    int[] array = new int[number.Length];
    for ( int i = 0; i < number.Length; i++)
    {
        array[i] = int.Parse(num[i].ToString());
        sum += array[i];
    }
    return sum;
}
