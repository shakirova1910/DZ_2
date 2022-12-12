// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int a; 
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
string num = a.ToString();
if (num.Length < 3)
    Console.Write($"третьей цифры нет");
else 
{Console.Write($"{a} -> {num[2]}");}