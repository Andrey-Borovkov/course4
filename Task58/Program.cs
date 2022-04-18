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
int[,] MatrixMultiplication(int[,] FirstArray, int[,] SecondArray)
{
    int[,] matrix = new int[FirstArray.GetLength(0), SecondArray.GetLength(1)];
    for (int i = 0; i < FirstArray.GetLength(0); i++)
    {
        for (int j = 0; j < SecondArray.GetLength(1); j++)
        {
            for (int k = 0; k < FirstArray.GetLength(1); k++)
            {
                matrix[i, j] += FirstArray[i, k] * SecondArray[k, j];
            }
            
        }
    }
    return matrix;
}

Console.Write("Введите количество строк первого массива: ");
int numbersOfLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первого массива: ");
int numbersOfColumns = Convert.ToInt32(Console.ReadLine());
int[,] FirstArray = Create2DArray(numbersOfLines, numbersOfColumns);

Console.Write("Введите количество строк второго массива: ");
int numbersOfLines2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второго массива: ");
int numbersOfColumns2 = Convert.ToInt32(Console.ReadLine());
int[,] SecondArray = Create2DArray(numbersOfLines2, numbersOfColumns2);

if (FirstArray.GetLength(1) == SecondArray.GetLength(0))
{
    Print2DArray(FirstArray);
    Console.WriteLine();
    Print2DArray(SecondArray);
    Console.WriteLine();

    int[,] matrix = MatrixMultiplication(FirstArray, SecondArray);
    Console.WriteLine();
    Console.WriteLine("Результат произведения двух матриц");
    Print2DArray(matrix);
}
else
{
    Console.WriteLine("Матрицы не согласованы!");
}
