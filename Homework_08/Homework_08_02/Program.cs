using static System.Console;

Clear();

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

WriteLine("<< Создайте прямоугольный массив, у которого строк больше чем столбцов. >>");
WriteLine();

Write("Введите число строк: ");
int rows = int.Parse(ReadLine());
Write("Введите число столбцов: ");
int columns = int.Parse(ReadLine());

int[,] randMatrix = GetMatrix(rows, columns, 1, 15);

if (rows <= columns)
{
    WriteLine();
    WriteLine("Неверный массив! Число строк, должно быть больше, чем столбцов.");
    WriteLine();
    return;
}

WriteLine();
PrintMatrix(randMatrix);
WriteLine();
RowCalc(randMatrix);
WriteLine();

int[,] GetMatrix(int row, int col, int min, int max)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} " );
        }
        Console.WriteLine();
    }
}

void RowCalc(int[,] matrix)
{
    int count = 0;
    int tempRow = int.MaxValue;
    int tempCount = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowsum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowsum += matrix[i, j];
        }
        count++;
        WriteLine($"Строка: {count}, Сумма элементов: {rowsum}");
        if (tempRow > rowsum)
        {
            tempRow = rowsum;
            tempCount = count;
        }
    }
    WriteLine();
    WriteLine($"Строка с наименьшей суммой элементов: {tempCount}");
}
