//Задача 25
// Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

int a;
Console.Write("Введите число a: ");
int.TryParse(Console.ReadLine(), out a);

int b = a;
int sum = 0;

while (b > 0)
{sum += b % 10;
b/=10;
 }
Console.Write(sum);

