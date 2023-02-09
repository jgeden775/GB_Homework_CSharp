Console.Clear();

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n < m) 
{
    Console.WriteLine("Некорректный ввод!");
}
else Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n}: " + SumNumber(m, n));

int SumNumber(int start, int end)
{
    if (end == start)
    {
        return start;
    }
    return (start + SumNumber(start + 1, end));
}
