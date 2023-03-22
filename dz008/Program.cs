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
/*
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
*/

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
/*
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 6);
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
void MultiplicationMatrix(int[,] array1, int[,] array2)
{

    if (array1.GetLength(1) == array2.GetLength(0))
    {    
        int[,] resultarray = new int[array1.GetLength(0), array2.GetLength(1)];
        int i1 = 0;    
        for (int i = 0; i < resultarray.GetLength(0); i++)
        {
            int j2 = 0;        
            for (int j = 0; j < resultarray.GetLength(1); j++)
            {
                int j1 = 0;
                int i2 = 0;           
                while(j1 < array1.GetLength(1))
                {
                    resultarray[i, j] += array1[i1,j1]*array2[i2,j2];
                    j1++;
                    i2++;
                }            
                j2++;     
            }
            i1++;
        }
        PrintMatrix(resultarray);
    }
    else    
        System.Console.WriteLine("Нельзя перемножить !!!");
    
}

int n1 = Number("Input row number: ");
int m1 = Number("Input colum number: ");
int[,] matrix = FillMatrixWithRandom(n1,m1);
PrintMatrix(matrix);
System.Console.WriteLine();
int n2 = Number("Input row number: ");
int m2 = Number("Input colum number: ");
int[,] matrix1 = FillMatrixWithRandom(n2,m2);
PrintMatrix(matrix1);
System.Console.WriteLine();
MultiplicationMatrix(matrix,matrix1);
*/

/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7 */
/*
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
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int FindMinMatrix(int[,] matrix)
{
    int min = matrix[0, 0];
    int k = 0;
    int l = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                k = i;
                l = j;
            }
        }
    }
    return k;
}
int FindMinMatrix1(int[,] matrix)
{
    int min = matrix[0, 0];
    int k = 0;
    int l = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                k = i;
                l = j;
            }
        }
    }
    return l;
}

int[,] FindMatrix(int[,] matrix, int k, int l)
{
    int[,] newarr = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];    
    int m = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int n = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {            
            if (i != k && j != l)
            {
                newarr[m,n] = matrix[i,j];
                n ++;
            }            
        }
        if(k != i)
            m ++;
    }
    return newarr;
}


int Number(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int n = Number("Input row number: ");
int m = Number("Input colum number: ");
int[,] matrix = FillMatrixWithRandom(n, m);
PrintMatrix(matrix);
System.Console.WriteLine();
int k = FindMinMatrix(matrix);
int l = FindMinMatrix1(matrix);
System.Console.WriteLine($"{k} , {l}");
System.Console.WriteLine();
int[,] newarr = FindMatrix(matrix, k, l);
PrintMatrix(newarr);
*/

/*  Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] array = new int[row, column];
    int el = 1;    
    for(int j =0; j < array.GetLength(1); j++)
    {
        array[0,j] = el;
        el ++;        
    }

    for(int i = 1; i < array.GetLength(0); i++)
    {
        array[i,column-1] = el;
        el ++;
    }
    
    for( int j = column-2; j >= 0; j--)
    {
        array[row-1,j] = el;
        el ++;
    }

    for(int i = row-2; i > 0; i--)
    {
        array[i,0] = el;
        el ++;
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
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

int n = Number("Input row number: ");
int m = Number("Input colum number: ");
int[,] matrix = FillMatrixWithRandom(n, m);
PrintMatrix(matrix);