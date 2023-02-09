/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();

Console.WriteLine("<< Является ли число полиндромом? >>");
start: 
Console.WriteLine();

Console.WriteLine("Введите пятизначное число: ");
string strnum = Console.ReadLine();
int[] arraynum = new int[strnum.Length];

if (strnum.Length < 5)
{
    Console.WriteLine();
    Console.WriteLine("Тут меньше пяти цифр. Нужно пятизначное число!");
    Console.WriteLine();
    goto start;
}
else
{
    if (strnum.Length > 5)
    {
        Console.WriteLine();
        Console.WriteLine("Тут больше пяти цифр. Нужно пятизначное число!");
        Console.WriteLine();
        goto start;
    }
    else
    {
        for (int i = 0; i < strnum.Length; i++)
        {
            arraynum[i] = int.Parse(strnum[i].ToString());
        }
    }
}
Console.WriteLine();
if (arraynum[0] == arraynum[4] && arraynum[1] == arraynum[3]) Console.WriteLine(">> Это число полиндром.");
else Console.WriteLine(">> Это число не полиндром.");

Console.WriteLine();
