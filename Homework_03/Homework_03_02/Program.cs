/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();
Console.WriteLine("<< Нахождение расстояние между точками в 3D пространстве >>");
Console.WriteLine();

Console.WriteLine("Введите координаты первой точки: ");
int n1c1 = int.Parse(Console.ReadLine());
int n1c2 = int.Parse(Console.ReadLine());
int n1c3 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите координаты второй точки: ");
int n2c1 = int.Parse(Console.ReadLine());
int n2c2 = int.Parse(Console.ReadLine());
int n2c3 = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Даны две точки: ({n1c1}, {n1c2}, {n1c3}) и ({n2c1}, {n2c2}, {n2c3})");
Console.WriteLine();

double ndist = Math.Sqrt(Math.Pow(n2c1 - n1c1, 2) + Math.Pow(n2c2 - n1c2, 2) + Math.Pow(n2c3 - n1c3, 2));
Console.WriteLine($"Расстояние между этими точками: {Math.Round(ndist, 2)}");
Console.WriteLine();
