//Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

int xa, xb, ya, yb, za, zb;
Console.Write($"введите координты X т.А: ");
int.TryParse(Console.ReadLine()!, out xa);
Console.Write($"введите координты Y т.А: ");
int.TryParse(Console.ReadLine()!, out ya);
Console.Write($"введите координты Z т.А: ");
int.TryParse(Console.ReadLine()!, out za);
Console.Write($"введите координты X т.B: ");
int.TryParse(Console.ReadLine()!, out xb);
Console.Write($"введите координты Y т.B: ");
int.TryParse(Console.ReadLine()!, out yb);
Console.Write($"введите координты Z т.B: ");
int.TryParse(Console.ReadLine()!, out zb);

int x = (xa - xb) * (xa - xb);
int y = (ya - yb) * (ya - yb);
int z = (za - zb) * (za - zb);

double ans = Math.Sqrt(x+y+z);

Console.Write($"Расстояние между точками = {ans}  ");