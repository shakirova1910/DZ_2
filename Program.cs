﻿/* Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
 */

Console.Write("Введи N: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи M: ");
int m = Convert.ToInt16(Console.ReadLine());

int AkkermanFunc(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AkkermanFunc(m - 1, 1);
			}
			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
		}
		
		Console.WriteLine(AkkermanFunc(m, n));