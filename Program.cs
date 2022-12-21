/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

 */

int [,] array = new int [4,4];

for (int i = 0; i<array.GetLength(0); i++)
{
    for (int j = 0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}


int imin = 0; 
int min = 0; 
for (int i = 0; i < array.GetLength(1); i++)
    min += array[0, i];
for (int i = 1; i < array.GetLength(1); i++)
{
    int sum = 0; 
    for (int j = 0 j < array.GetLength(1); j++)
        sum += array[1. j];
    if (sum<min)
    {
        min = sum;
        imin = i;
    }
    }
Console.Write($"{imin}");