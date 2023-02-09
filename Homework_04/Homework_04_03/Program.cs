/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();

bool run = true;
while(run)
{
    int[] nums = FillArray(new int[8], 99); // Задаём размер массива и предельное число для автозаполнения
    Console.WriteLine($"[{String.Join(", ", nums)}]"); // Выводим этот массив

    Console.WriteLine();
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("Нажмите [Enter] для перезапуска программы.");
    Console.WriteLine("Нажмите любую клавишу чтобы выйти.");
    Console.WriteLine();
    run = Console.ReadKey().Key == ConsoleKey.Enter;
}

int[] FillArray(int[] array, int lim) //Создаём массив случайных чисел
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, lim);
    }
    return array;
}
