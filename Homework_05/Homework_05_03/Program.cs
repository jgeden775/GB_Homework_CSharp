using static System.Console;
Clear();

/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] array = GetArray(5, -10, 10);
WriteLine("Генерируем массив заполненный случайными вещественными числами:");
WriteLine(String.Join(", ", array));
WriteLine();
WriteLine($"Разница между максимальным и минимальным элементом массива: {DiffMinMax(array)}");
WriteLine();

double[] GetArray(int size, double minvalue, double maxvalue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * ((maxvalue) - minvalue) + minvalue, 2);
    }
    return result;
}

double DiffMinMax(double[] array)
{
double result = 0;
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            double temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
}
    result = array[array.Length - 1] - array[0];
    return result;
}
