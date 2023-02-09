/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();
Console.WriteLine("<< Нахождение кубов чисел от 1 до N >>");
Console.WriteLine();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Кубы чисел от 1 до {num}:");
Console.Write(">> ");
for (int i = 1; i < num; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}
Console.WriteLine();
Console.WriteLine();
