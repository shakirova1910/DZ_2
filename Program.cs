// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int a;
Console.Write($"введите день недели: ");
int.TryParse(Console.ReadLine()!, out a);

if (a == 6 || a == 7)
    Console.Write($"Выходной"); 
else if (a > 0 && a < 6)
        Console.Write($"не выходной");
else 
    Console.Write($"НЕ ДЕНЬ НЕДЕЛИ! ");  