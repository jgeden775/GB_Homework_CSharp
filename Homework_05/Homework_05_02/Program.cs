using static System.Console;
Clear();

/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = GetArray(5, -99, 100);
WriteLine("Генерируем массив заполненный случайными числами:");
WriteLine(String.Join(", ", array));
WriteLine();
WriteLine($"Сумма елементов, стоящих на нечётных позициях, в нём: {OddSum(array)}");
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

int OddSum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 != 0) result += array[i];
    }
    return result;
}
