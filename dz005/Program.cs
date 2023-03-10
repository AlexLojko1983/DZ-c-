/* Task1: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2   */
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
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(100, 1000);
}
return arr;
}

int  Parity(int[] arr)
{
    int cound = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0)
            cound++;
    }
    return cound;
}

int size = Number("Input size array: ");
int[] arr = FillArray(size);
int cound = Parity(arr);
System.Console.WriteLine($"There are {cound} even numbers in the [{string.Join(", ", arr)}]");
*/

/* Task2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0        */
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

int Sum(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(i % 2 > 0)
            sum += arr[i];
    }
    return sum;
}

int size = Number("Input size array: ");
int minDigit = Number("Input minimum array number: ");
int maxDigit = Number("Input maximum array number: ");

int[] arr = FillArray(size, minDigit, maxDigit);

int sum = Sum(arr);

System.Console.WriteLine($"sum of odd indices [{string.Join(", ", arr)}] = {sum}");
*/

/* Task3: Задайте массив вещественных чисел(тип double).
Найдите разницу между максимальным и минимальным элементов массива.
[3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1     */

int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double[] FillArray(int size, int minDigit, int maxDigit)
{
double[] arr = new double[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = Math.Round(rnd.NextDouble(), 1) + rnd.Next(minDigit,maxDigit);
}
return arr;
}

double Range(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for(int i = 1; i<arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
        else if(arr[i] < min)
        {
            min = arr[i];
        }
    }
    return max - min;
}

int size = Number("Input size array: ");
int minDigit = Number("Input minimum array number: ");
int maxDigit = Number("Input maximum array number: ");

double[] arr = FillArray(size, minDigit, maxDigit);

double range = Math.Round(Range(arr), 1);

System.Console.WriteLine($"element range in [{string.Join("_ ", arr)}] = {range}");

