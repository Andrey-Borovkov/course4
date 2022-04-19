/* 
    Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
*/
int SumOfIntegers(int m, int n, int sum = 0)
{
    if (m <= n)
    {
        sum = m + SumOfIntegers(m + 1, n);
        return sum;
    }
    else
    {
        return sum;
    }
}
Console.Write($"Сумма натуральных элементов равна {SumOfIntegers(1, 15)}");
