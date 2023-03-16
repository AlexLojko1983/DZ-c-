/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
double[,] FillMatrixWithRandom(int row, int column)
{
    double[,] array = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble(), 1) + rnd.Next(-10,116);
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int row = Number("Введите кол-во строк: ");
int column = Number("Введите кол-во столбцов: ");
double[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
*/
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] FillMatrixWithRandom()
{
    int[,] array = new int[5, 6];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void Elemens(int[,] matrix, int n, int m)
{
    if(matrix.GetLength(0) > n && matrix.GetLength(1) > m)
        System.Console.WriteLine(matrix[n,m]);
    else
        System.Console.WriteLine("такого элемента в массиве нет");
}

void FindElemens(int[,] matrix, int k )
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {       
            if(matrix[i,j] == k)
            {
                System.Console.WriteLine($"Еhe number {k} is in a row = {i}, column = {j}");                   
            }        
            else
            {
                count++;
            }
        }        
    }
    if(count == matrix.Length)
        System.Console.WriteLine("такого элемента в массиве нет");
}

int[,] matrix = FillMatrixWithRandom();
int n = Number("Input row number: ");
int m = Number("Input colum number: ");
PrintMatrix(matrix);
System.Console.WriteLine();
Elemens(matrix, n, m);

int k = Number("Input number: ");
FindElemens(matrix, k);


/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

