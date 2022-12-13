//Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
  
  
int Exponentiation(int a, int b){
  int result = 1;
  for(int i=1; i <= b; i++){
    result = result * a;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}
  int exponentiation = Exponentiation(a, a);
  Console.WriteLine( exponentiation);