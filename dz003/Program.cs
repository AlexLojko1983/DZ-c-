// Task1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

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
        Console.Write(message);
        Int32.TryParse(Console.ReadLine(), out num);
    }
    while(num < 10000 || num >= 100000);
    return num;
    
}
int number = Number("Input five-digital number: ");
Palindrom(number);


/* Task2: Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.*/
/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)   
{
    double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return distance;
}
double Input(string message)
{   
    Console.Write(message);
    double a = Convert.ToDouble(Console.ReadLine());
    
    return a; 
}

double x1 = Input("Input coordinate x1: ");
double y1 = Input("Input coordinate y1: ");
double z1 = Input("Input coordinate z1: ");
double x2 = Input("Input coordinate x2: ");
double y2 = Input("Input coordinate y2: ");
double z2 = Input("Input coordinate z2: ");

Console.WriteLine(Math.Round(Distance(x1,y1,z1,x2,y2,z2),2));
*/

// Task3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}    

int num = Number("Input number: ");
for(int i = 1; i <= num; i++)
Console.WriteLine(Math.Pow(i, 3));*/