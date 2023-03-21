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
   
   
   while (i < matrix.GetLength(0))
    {
        int k = 0;
        int max =matrix[i,k];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] > max)
            {
                max = matrix[i,j];
                matrix[i,j] = matrix[i,k];
                matrix[i,k] = max;                
            }  
                                  
        } 
        // k = 0;
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
