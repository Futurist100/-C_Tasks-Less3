// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 5,3 = 243
// 2,4 = 16


System.Console.WriteLine("Введите число A ");

int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B");

int degree = Convert.ToInt32(Console.ReadLine());

int temp = 1;

for (int i = 1; i <= degree; i++)
      {  
           
       System.Console.WriteLine(i);

        temp = temp * number;
 
      }

     System.Console.WriteLine($"Результат равенO: {temp}");