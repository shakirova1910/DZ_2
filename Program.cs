﻿/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. 
Напишите программу, которая покажет 
количество чётных чисел в массиве.*/

int[] array = new int [3];
for (int i = 0;i < array.Length ; i++)
    array[i] = new Random().Next(100,1000);
int k = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
        k++;
        
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.Write($"-> {k}");

 
