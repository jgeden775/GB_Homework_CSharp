using static System.Console;
Clear();

/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] array = GetArray(10, 100, 1000);
WriteLine("Генерируем массив заполненный случайными положительными трёхзначными числами:");
WriteLine(String.Join(", ", array));
WriteLine();
WriteLine($"Количество чётных чисел в нём: {EvenAmout(array)}");
WriteLine();

int[] GetArray(int size, int minvalue, int maxvalue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minvalue, maxvalue);
    }
    return result;
}

int EvenAmout(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) result += 1;
    }
    return result;
}
