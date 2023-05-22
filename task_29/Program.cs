// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


System.Console.WriteLine("Введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите верх диапазона: ");

int top = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[size];
Random rand = new Random(); 
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rand.Next(0, top);

}
Console.WriteLine('[' + string.Join(", ", arr) + ']');