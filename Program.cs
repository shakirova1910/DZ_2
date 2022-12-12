// Задача 23

//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

int n;
Console.Write($"введите число: ");
int.TryParse(Console.ReadLine()!, out n);

for (int i = 1; i <= n; i++)
    Console.Write($"{(i * i) * i} ");
