/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] Create2DArray(int rows, int columns)
{
    int[,] Array = new int[rows, columns];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 11);
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
double[] AverageOfColumns(int[,] array2D)
{
    double[] array = new double[array2D.GetLength(1)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array[i] += array2D[j, i];
        }
        array[i] /= array2D.GetLength(0);
    }
    return array;
}
void PrintAverageOfColumns(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)
        {
            Console.Write("; ");
        }
    }
    Console.Write(".");
}
Console.Write("Введите количество строк массива: ");
int numbersOfLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int numbersOfColumns = Convert.ToInt32(Console.ReadLine());
int[,] Array = Create2DArray(numbersOfLines, numbersOfColumns);
Print2DArray(Array);
double[] newArray = AverageOfColumns(Array);
PrintAverageOfColumns(newArray);