/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Clear();
Console.WriteLine("<< Нахождение всех чётных чисел в заданном интервале >>");
Console.WriteLine();
Console.Write("Введите число (это будет предел интервала): ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Чётные числа, в интевале от 1 до {num}:");
Console.Write(">> ");
for (int index = 1; index <= num; index++)
{
    if (index%2 == 0)
    {
        Console.Write(index + " ");
    }
}
Console.WriteLine();
Console.WriteLine();