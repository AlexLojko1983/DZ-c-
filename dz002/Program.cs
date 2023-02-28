/*Task1:  Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.*/
/*
int SecondNumber(int number)
{
    return number % 100 / 10;
}

int num;
do
{
    Console.Write("Input a three-digit number: ");
    Int32.TryParse(Console.ReadLine(), out num);
}
while (num <= 99 || num >= 1000);

Console.WriteLine($"From the number {num}, the second digit {SecondNumber(num)}");
*/
// Task2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void ThreeNumber (int number)
{
    if(number > 99)
    {
        int number_digit = 1;
        int count = 0;
        while (number/number_digit >= 1)
        {
            number_digit *= 10;
            count++;                // Ищем разрядность числа
        }
        if(count > 3)
        {            
            int digit = number/Convert.ToInt32(Math.Pow(10,count-3))%10;
            Console.WriteLine(digit);
        }   
        if(count == 3)
        {
            int digit = number%10;
            Console.WriteLine(digit);
        }        
    }
    else
        Console.WriteLine("three digit not");
}

Console.Write("Input Number: ");
int number = Convert.ToInt32(Console.ReadLine());
ThreeNumber(number);
*/
/* Task3: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.*/

void Weekend(int number)
{
    if(number == 6 || number == 7)
        Console.WriteLine("Yes weekend");
    if(number > 7)
        Console.WriteLine("ERROR: there are seven days in a week");
    else
        Console.WriteLine("Not weekend");
}
Console.Write("Input Number: ");
int number = Convert.ToInt32(Console.ReadLine());
Weekend(number);