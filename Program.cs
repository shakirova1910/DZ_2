﻿/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
 */

int [,] array = new int [3,4];

for (int i = 0; i<array.GetLength(0); i++)
{
    for (int j = 0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}





;
for (int j = 0; j<array.GetLength(0); j++)
{
        int sum = 0;
        for (int i = 0; i<array.GetLength(0); i++)
            sum += array [i, j];
    Console.Write($"{Math.Round((double)sum/array.GetLength(0), 1)} ");
}



/*for (int i = 0; i<array.GetLength(0); i++)
{
    for (int j = 0; j<array.GetLength(1); j++)
        Console.Write($"{array[i,j]} ");
    Console.WriteLine();
}*/