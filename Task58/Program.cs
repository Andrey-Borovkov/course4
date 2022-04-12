/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/
int[,] Create2DArray(int rows, int columns)
{
    int[,] Array = new int[rows, columns];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 4);
        }
    }
    return Array;
}
void Print2DArray(int[,] PrintedArray)
{
    for (int i = 0; i < PrintedArray.GetLength(0); i++)
    {
        for (int j = 0; j < PrintedArray.GetLength(1); j++)
        {
            Console.Write($"{PrintedArray[i, j]} \t ");
        }
        Console.WriteLine();
    }
}
int[,] MatrixMultiplication (int[,] FirstArray, int[,] SecondArray)
{
    int[,] matrix = new int[FirstArray.GetLength(0), SecondArray.GetLength(1)];
    for (int i = 0; i < FirstArray.GetLength(0); i++)
    {
        for (int j = 0; j < FirstArray.GetLength(0); j++)
        {
            for (int k = 0; k < SecondArray.GetLength(1); k++)
            {
                matrix[i, k] = FirstArray[i, j] * SecondArray
            }
        }
    }
}