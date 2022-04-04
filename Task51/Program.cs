/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
int[,] CreateArray(int rows, int columns)
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
void PrintArray(int[,] PrintedArray)
{
    for (int i = 0; i < PrintedArray.GetLength(0); i++)
    {
        for (int j = 0; j < PrintedArray.GetLength(1); j++)
        {
            Console.Write($"{PrintedArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void SumOfElements(int[,] array)
{
    int sum = 0;
    if (array.GetLength(0)>array.GetLength(1))
    {
        Console.Write($"Сумма элементов главной диагонали равна ");
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum+=array[i, i];
            Console.Write(array[i, i]);
            if (i<array.GetLength(1)-1)
            {
                Console.Write(" + ");
            }
        }
        Console.Write($" = ");
    }
    else
    {
        Console.Write($"Сумма элементов главной диагонали равна ");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum+=array[i, i];
            Console.Write(array[i, i]);
            if (i<array.GetLength(0)-1)
            {
                Console.Write(" + ");
            }
        }
        Console.Write($" = ");
    }
    Console.Write(sum);
}
Console.Write("Введите количество строк массива: ");
int numbersOfLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int numbersOfColumns = Convert.ToInt32(Console.ReadLine());
int[,] Array = CreateArray(numbersOfLines, numbersOfColumns);
PrintArray(Array);
Console.WriteLine();
SumOfElements(Array);

        
