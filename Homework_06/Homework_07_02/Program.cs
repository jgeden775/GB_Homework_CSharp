using static System.Console;
Clear();

/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] array = {{5, 3, 0, 2, 3},
                {7, 8, 6, 7, 1},
                {0, 3, 5, 9, 2},
                {4, 5, 7, 0, 6},
                {2, 7, 0, 7, 3}};

Write("Введите номер строки : ");
int rownum = int.Parse(ReadLine());
Write("Введите номер столбца : ");
int colnum = int.Parse(ReadLine());

if (rownum >= array.GetLength(0) | colnum >= array.GetLength(1))
{
    WriteLine("Такого значения в массиве нет!");
}
else WriteLine($"Значение этого элемента: {array[rownum, colnum]}");
WriteLine();
