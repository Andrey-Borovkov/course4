/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
int[,] SortRows(int[,] CreatedArray)
{
    for (int i = 0; i < CreatedArray.GetLength(0); i++)
    {
        for (int j = 0; j < CreatedArray.GetLength(1); j++)
        {
            for (int k = 0; k < CreatedArray.GetLength(1) - 1; k++)
            {
                int tempValue = CreatedArray[i, k];
                if (CreatedArray[i, k] < CreatedArray[i, k+1])
                {
                    CreatedArray[i, k] = CreatedArray[i, k+1];
                    CreatedArray[i, k+1] = tempValue;
                }

            }

        }
    }
    return CreatedArray;
}
Console.Write("Введите количество строк массива: ");
int numbersOfLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int numbersOfColumns = Convert.ToInt32(Console.ReadLine());
int[,] Array = Create2DArray(numbersOfLines, numbersOfColumns);
Print2DArray(Array);
Console.WriteLine();
int[,] newArray = SortRows(Array);
Print2DArray(newArray);
