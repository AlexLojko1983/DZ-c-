/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
/*
void PrintNumberToN(int N)
{    
    if (N == 0)
    {
        return;
    }
    System.Console.Write($"{N} ");
    PrintNumberToN(N-1);    
}
System.Console.Write("Введите число N: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
PrintNumberToN(firstNumber);
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
int PrintNumberToN(int N, int M)
{
if (N == M-1)
{
return;
}
PrintNumberToN(N - 1, M);
System.Console.Write(N + PrintNumberToN(N - 1, M));
}
System.Console.Write("Введите число N: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число М: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
PrintNumberToN(firstNumber, secondNumber);

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/