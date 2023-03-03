// Task1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrom(int number)
{    
    if(number/10000 == number%10 && number/1000%10 == number%100/10) 
        Console.WriteLine($"{number} is polindrom");
    else
        Console.WriteLine($"{number} is not polindrom");
}

int Number(string message)
{
    int num;
    do
    {
        Console.WriteLine(message);
        Int32.TryParse(Console.ReadLine(), out num);
    }
    while(num < 10000 || num >= 100000);
    return num;
    
}
int number = Number("Input five-digital number: ");
Palindrom(number);
*/