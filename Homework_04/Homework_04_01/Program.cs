/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();

Console.Write("Введите число: ");
double numA = double.Parse(Console.ReadLine());
Console.Write("Введите степень возведения: ");
double numB = double.Parse(Console.ReadLine());
double numX = 1;
for (double i = 0; i < numB; i++)
{
    numX *= numA;
}
Console.WriteLine("Число {0} в степени {1}: {2}", numA, numB, numX);
Console.WriteLine();
