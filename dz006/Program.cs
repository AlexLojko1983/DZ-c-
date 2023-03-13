/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3     */

/*
int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] FillArray(int size)
{
int[] arr = new int[size];

for(int i = 0; i < arr.Length; i++)
{
    Console.Write($"Input arr{i}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
return arr;
}

int Count(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
            count++;
    }
    return count;
}

int m = Number("Input M = ");
int[] arr = FillArray(m);
int count = Count(arr);

System.Console.WriteLine($"[{string.Join(", ", arr)}]");
System.Console.WriteLine(count);
*/

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
  задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)      */


double Number(string message)
{
    Console.Write(message);
    double number = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
    return number;
}

double b1 = Number("Input b1: ");
double b2 = Number("Input b2: ");
double k1 = Number("Input k1: ");
double k2 = Number("Input k2: ");

double x = Math.Round((b1 - b2) / (k2 - k1), 2);
double y = Math.Round(k1 * x + b1, 2);

if (k1 != k2)
    System.Console.WriteLine($"({x};{y}))");
else
    System.Console.WriteLine("lines are parallel");
