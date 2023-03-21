/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
/*
int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
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
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 20);
        }
    }
    return array;
}

int[,] SortedMatrix(int[,] matrix)
{   
   int i = 0;
   while (i<matrix.GetLength(0))
   {   
        int k = 0;
        while (k < matrix.GetLength(1))
        {        
            int max =matrix[i,k];
            for (int j = k; j < matrix.GetLength(1); j++)
            {
                if (matrix[i,j] > max)
                {
                    max = matrix[i,j];
                    matrix[i,j] = matrix[i,k];
                    matrix[i,k] = max;                
                }                                  
            } 
            k ++;
        }
        i++;                          
    } 
    return matrix;
}

int n = Number("Input row number: ");
int m = Number("Input colum number: ");
int[,] matrix = FillMatrixWithRandom(n,m);
PrintMatrix(matrix);
System.Console.WriteLine();
int[,] newmatrix = SortedMatrix(matrix);
PrintMatrix(newmatrix);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
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
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 20);
        }
    }
    return array;
}

int[] SumRowMatrix(int[,] matrix)
{   
   int i = 0;
   int k = 0;
   int[] array = new int[matrix.GetLength(0)];
   while (i < matrix.GetLength(0))
   {
        int sum = 0;            
        int max = matrix[i,k];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];                                  
        }
        array[k] = sum;
        k++;
        i++;                          
    } 
    return array;
}

int n = Number("Input row number: ");
int m = Number("Input colum number: ");
int[,] matrix = FillMatrixWithRandom(n,m);
PrintMatrix(matrix);
System.Console.WriteLine();
int[] arr = SumRowMatrix(matrix);
System.Console.WriteLine($"[{string.Join(", ", arr)}]");
System.Console.WriteLine($"Наименьшая сумма элементов в {Array.IndexOf(arr, arr.Min())} строке");
*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,,] FillMatrixWithRandom(int row, int column, int height)
{
    int[,,] array = new int[row, column,height];
    int[] arr = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];

    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                do
                {                    
                    array[i, j, k] = rnd.Next(10, 100);                                        
                } 
                while (Array.IndexOf(arr, array[i,j,k]) != -1);
                arr = arr.Append(array[i, j, k]).ToArray();                
            }            
        }
    }
    return array;
}

void PrintMatrix(int[,,] array)
{
    int k = 0;
    while (k < array.GetLength(2))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) \t");
            } 
            Console.WriteLine();                       
        }
        k++;
    }        
}

int n = Number("Input row number: ");
int m = Number("Input colum number: ");
int h = Number("Input height number: ");
int[,,] matrix = FillMatrixWithRandom(n,m,h);
PrintMatrix(matrix);
System.Console.WriteLine();
