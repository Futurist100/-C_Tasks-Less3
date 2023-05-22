// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Sum(string number)
{

char[] ch = number.ToCharArray();

int sum = 0;

int a = 0;

for (int i = 0; i <= number.Length - 1; i++)
{

   a = int.Parse(Convert.ToString(ch[i]));

   sum = sum + a;

}
    return sum;
}

System.Console.WriteLine("Введите число: ");
string num = (Console.ReadLine());
int sum = Sum(num);
System.Console.WriteLine($"Сумма цифр числа {num} = {sum}");