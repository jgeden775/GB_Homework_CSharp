using static System.Console;

Clear();

/*
Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int n = 4;
int m = 4;
int[,] matrix = new int[n, m];

SpiralMatrix(matrix);
PrintMatrix(matrix);
WriteLine();

void SpiralMatrix(int[,] matrix)
{
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int filling = m;

    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[row, col] = i + 1;
        if (--filling == 0) 
        {
            filling = m * (dirChanges %2) + n * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j].ToString("D2")} " );
        }
        WriteLine();
    }
}
