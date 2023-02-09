using static System.Console;

Clear();

/*
Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Write("Введите число x: ");
int x = int.Parse(ReadLine());
Write("Введите число y: ");
int y = int.Parse(ReadLine());
Write("Введите число z: ");
int z = int.Parse(ReadLine());

int[,,] matrix = GetMatrix(x, y, z, 10, 99);

WriteLine();
PrintMatrix(matrix);
WriteLine();

int[,,] GetMatrix(int x, int y, int z, int min, int max)
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }
    return result;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Write($"{matrix[i, j, k]} ");
                WriteLine($"{(i, j, k)}");
            }
        }
    }
}
