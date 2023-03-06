/* Task1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Degree(int number, int degree)
{
    int result = 1;
    for(int i =1; i <= degree; i++)
    {
        result *= number;
    }
    return result;
}

int num = Number("Input number: ");
int degree = Number("Input degree of: ");

int newnumber = Degree(num, degree);
Console.WriteLine($"number {num} to the power {degree} = {newnumber}");
*/

// Task2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumNumbers(int number)
{
    int sum = 0;
    while(number >= 1)
    {
        sum += number%10;
        number /=10;
    }
    return sum;
}

int number = Number("Input number: ");
int sumNumber = SumNumbers(number);
Console.WriteLine($"sum of numbers{number} = {sumNumber}"); 
*/

// Task3-1: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
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

System.Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
*/
// Task3-2: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] FillArray(int size, int minDigit, int maxDigit)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(minDigit, maxDigit);
}
return arr;
}

int size = Convert.ToInt32(Number("Input size: "));
int minDigit = Convert.ToInt32(Number("Input minDigit: "));
int maxDigit = Convert.ToInt32(Number("Input maxDigit: "));
int[] array = FillArray(size, minDigit, maxDigit);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
*/