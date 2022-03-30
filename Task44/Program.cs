/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/


int[] CreateFibonacciArray(int Number)
{
    int[] FibonacciArray = new int[Number];
    FibonacciArray[0] = 0;
    FibonacciArray[1] = 1;
    for (int i = 2; i < FibonacciArray.Length; i++)
    {
        FibonacciArray[i] = FibonacciArray[i - 2] + FibonacciArray[i - 1];
    }
    return FibonacciArray;
}

void PrintFibonacciNumbers(int[] InputArray)
{
    for (int i = 0; i < InputArray.Length; i++)
    {
        Console.Write($"{InputArray[i]} ");
    }
}

Console.Write("Введите количество чисел Чибоначи: ");
int Number = Convert.ToInt32(Console.ReadLine());
int[] ArrayOfFibonacciNumbers = CreateFibonacciArray(Number);
PrintFibonacciNumbers(ArrayOfFibonacciNumbers);

















