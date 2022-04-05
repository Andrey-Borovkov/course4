/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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
int[,] ChangeColumnsArray(int[,] inputArray)
{
    int tempValue = new int();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        tempValue = inputArray[0, i];
        inputArray[0, i] = inputArray[inputArray.GetLength(0) - 1, i];
        inputArray[inputArray.GetLength(0) - 1, i] = tempValue;
    }
    return inputArray;
}
Console.Write("Введите количество строк массива: ");
int numbersOfLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int numbersOfColumns = Convert.ToInt32(Console.ReadLine());
int[,] Array = Create2DArray(numbersOfLines, numbersOfColumns);
Print2DArray(Array);
Console.WriteLine();
int[,] changedArray = ChangeColumnsArray(Array);
Print2DArray(Array);