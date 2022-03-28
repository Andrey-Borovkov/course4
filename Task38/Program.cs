/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void CreateArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(-100, 101);
    }
}

void ShowArray(double [] array)
{
        Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

double DiffOfNumbers(double [] array)
{
    double result = new double();
    double MinOfNumbers = array[0];
    double MaxOfNumbers = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > MaxOfNumbers)
        {
            MaxOfNumbers = array[i];
        }
        else
        {
            if (array[i] < MinOfNumbers)
            {
                MinOfNumbers = array[i];
            }
        }
    }
    result = MaxOfNumbers - MinOfNumbers;
    return result;
}

Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] arr = new double [size];
CreateArray(arr);
ShowArray(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {DiffOfNumbers(arr)}");