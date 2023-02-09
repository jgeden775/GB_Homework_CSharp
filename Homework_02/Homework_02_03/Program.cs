/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();

Console.WriteLine("<< Отображение выходных дней недели >>");
Console.WriteLine();

int[] arrayWeek = {1, 2, 3, 4, 5, 6, 7};

Console.WriteLine("Введите номер дня недели (от 1 до 7): ");
int numDay = int.Parse(Console.ReadLine());

if (numDay > arrayWeek.Length)
Console.WriteLine("Эй! Ты ошибся. В неделе всего 7 дней.");
Console.WriteLine();

for (int i = 0; i < arrayWeek.Length; i++)
{
    string dayName = " ";
    string dayOff = " ";
    if (arrayWeek[i] == numDay)
    {
        if (arrayWeek[i] == 1) dayName = "понедельник.";
        if (arrayWeek[i] == 2) dayName = "вторник.";
        if (arrayWeek[i] == 3) dayName = "среда, мои чуваки! Аааааааааааааа!!!"; // Не удержался))
        if (arrayWeek[i] == 4) dayName = "четверг.";
        if (arrayWeek[i] == 5) dayName = "пятница.";
        if (arrayWeek[i] == 6) dayName = "суббота!";
        if (arrayWeek[i] == 7) dayName = "воскресенье!";

        if (arrayWeek[i] > 5)
        {
            dayOff ="Выходной день.";
        }
        else
        {
            dayOff ="Будний день.";
        }
        Console.WriteLine($"Это {dayName} {dayOff}");
        Console.WriteLine();
    }
}
