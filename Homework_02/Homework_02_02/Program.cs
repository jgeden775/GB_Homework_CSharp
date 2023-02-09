/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();

Console.WriteLine("<< Отображение третьей цифры числа >>");
Console.WriteLine();

Console.WriteLine("Введите минимум трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
string strnum = num.ToString();
int[] arraynum = new int[strnum.Length];

if (strnum.Length < 3)
{
    Console.WriteLine();
    Console.WriteLine("Третьей цифры нет!");
    Console.WriteLine("Тут меньше трёх цифр. Нужно трёхзначное число.");
    Console.WriteLine();
}
else
{
    for ( int i = 0; i < strnum.Length; i++)
        {
            arraynum[i] = int.Parse(strnum[i].ToString());
        }
    Console.WriteLine();
    Console.WriteLine($"Третья цифра этого числа: {arraynum[2]}");
    Console.WriteLine();
}
