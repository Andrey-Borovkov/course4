/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int SmallPowOfArray(int[,] CreatedArray)
{
    int[] Array = new int[CreatedArray.GetLength(0)];
    for (int i = 0; i < CreatedArray.GetLength(0); i++)
    {
        int sum = new int();
        for (int j = 0; j < CreatedArray.GetLength(1); j++)
        {
            sum += CreatedArray[i, j];
        }
        Array[i] = sum;
    }
    int numberOfPow = 1;
    for (int i = 0; i < Array.Length - 1; i++)
    {
        if (Array[i] > Array[i + 1])
        {
            numberOfPow = i + 2;
        }
    }
    return numberOfPow;
}

Console.Write("Введите количество строк массива: ");
int numbersOfLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int numbersOfColumns = Convert.ToInt32(Console.ReadLine());
int[,] Array = Create2DArray(numbersOfLines, numbersOfColumns);
Print2DArray(Array);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма построчных элементов находится в {SmallPowOfArray(Array)}-й строке");