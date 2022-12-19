/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами. */

int m, n;
Console.WriteLine("введите значение m: ");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("введите значение n: ");
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int [m, n];
 
for (int i = 0; i < array.GetLength(0); i++)
{   
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random() .Next(-9, 10);
        Console.Write($"{array[i, j]} ");
    } 
    
Console.WriteLine();
    }

