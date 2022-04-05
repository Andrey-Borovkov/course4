/*
 Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
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
void PositionsOfArrayElements(int position, int[,] createdArray)
{
    int numberOfPow = 0;
    int numberOfColumn = 0;
    if (position <= createdArray.GetLength(0) * createdArray.GetLength(1))
    {
        if (position % createdArray.GetLength(1) == 0)
        {
            numberOfColumn = createdArray.GetLength(1) - 1;
            numberOfPow = position / createdArray.GetLength(1) - 1;
        }
        else
        {
            numberOfColumn = (position % createdArray.GetLength(1)) - 1;
            numberOfPow = (position - position % createdArray.GetLength(1)) / createdArray.GetLength(1);
        }
        Console.WriteLine($"Значение элемента на {position}-ой позиции равно = {createdArray[numberOfPow, numberOfColumn]}");
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}

Console.Write("Введите количество строк массива: ");
int numbersOfLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int numbersOfColumns = Convert.ToInt32(Console.ReadLine());
int[,] Array = Create2DArray(numbersOfLines, numbersOfColumns);
Print2DArray(Array);
Console.WriteLine();
Console.Write("Введите позицию элемента: ");
int position = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
PositionsOfArrayElements(position, Array);
