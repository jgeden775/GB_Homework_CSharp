/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Clear();
Console.WriteLine("<< Чётное или нечётное число >>");
Console.WriteLine();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (num%2 == 0)
{
    Console.WriteLine($">> Число {num} - ЧЁТНОЕ");
}
else
{
    Console.WriteLine($">> Число {num} - НЕЧЁТНОЕ");
}
Console.WriteLine();
