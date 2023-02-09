using static System.Console;
Clear();

/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Write("Введите количество строк: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int columns = int.Parse(ReadLine());

double[,] table = new double[rows, columns];

FillTable(table, -99, 100);
WriteLine();
WriteLine("Создаём двумерный массив:");
WriteLine();
PrintTable(table);
WriteLine();

void FillTable(double[,] matrix, double minval, double maxval)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * ((maxval) - minval) + minval, 2);
        }
    }
}

void PrintTable(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
