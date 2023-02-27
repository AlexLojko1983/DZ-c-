//Task1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a number1: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a number2: ");
double number2 = Convert.ToDouble(Console.ReadLine());

if (number1 > number2)
    Console.WriteLine("max = " + number1);
else
    Console.WriteLine("max = " + number2);
    */

//Task2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a number1: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a number2: ");
double number2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a number3: ");
double number3 = Convert.ToDouble(Console.ReadLine());

if (number1 > number2 && number1 > number3)
    Console.WriteLine("max = " + number1);
else if (number2 > number1 && number2 > number3)
    Console.WriteLine("max = " + number2);
else if (number3 > number1 && number3 > number2)
    Console.WriteLine("max = " + number3);
else
    Console.WriteLine("max = multiple numbers");
    */

/*Task3: Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка).*/
/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
    Console.WriteLine("number is even ");
else
    Console.WriteLine("number is not even");

*/
// Task4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Write("Input a pozitiv number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;
while (current <= number)
{
    if (current%2 == 0)
        Console.Write(" " + current);
    current++;
}