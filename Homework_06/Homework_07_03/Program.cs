using static System.Console;
Clear();

/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] myArray = {{ 2, 7, 4, 12},
                  {11, 18, 3, 7},
                  { 9, 0, 15, 1},
                  { 5, 3, 17, 6}};

ColumnAverage(myArray);
WriteLine();

void ColumnAverage(int[,] table)
{
    for (int i = 0; i < table.GetLength(1); i++)
    {
        int colSum = 0;
        for (int j = 0; j < table.GetLength(0); j++)
        {
            colSum += table[j, i];
        }
        double avg = Convert.ToDouble(colSum) / Convert.ToDouble(table.GetLength(0));
        Console.WriteLine($"Среднее арифметическое столбца {i}: {avg}");
    }
}
