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
    int result = Convert.ToInt32(Math.Pow(number, degree));
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

// Task3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

