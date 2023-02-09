/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();

Console.WriteLine("<< Отображение второй цифры трёхзначного числа >>");
Console.WriteLine();

Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
string strnum = num.ToString();
int[] arraynum = new int[strnum.Length];

if (strnum.Length < 3)
{
    Console.WriteLine();
    Console.WriteLine("Тут меньше трёх цифр. Нужно трёхзначное число.");
    Console.WriteLine();
}
else
{
    if (strnum.Length > 3)
    {
        Console.WriteLine();
        Console.WriteLine("Тут больше трёх цифр. Нужно трёхзначное число.");
        Console.WriteLine();
    }
    else
    {
        for ( int i = 0; i < strnum.Length; i++)
        {
            arraynum[i] = int.Parse(strnum[i].ToString());
        }
        Console.WriteLine();
        Console.WriteLine($"Вторая цифра этого числа: {arraynum[1]}");
        Console.WriteLine();
    }
}
