/* Задача 36
 Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.*/

int[] array = new int [7];
for (int i = 0; i < array.Length ; i++)
    array[i] = new Random().Next(10);
int k = 0;
for (int i = 1; i < array.Length; i += 2)
        k+= array[i];
        
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.Write($"-> {k}");

 
