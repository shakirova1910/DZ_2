/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь. */

string[] numbers = Console.ReadLine()!.Split(" ");
int[] array  = new int [numbers.Length];
for (int i = 0; i < numbers.Length; i++)
   { int.TryParse(numbers [i], out array[i] );
    Console.Write($"{array [i]} ");}

int a = 0; 
foreach (var i in array)
if (i>0)
a++;

Console.Write ($"{a}");
 
