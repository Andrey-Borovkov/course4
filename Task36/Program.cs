/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
void CreateArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(-100, 101);
    }
}

void ShowArray(int[] array)
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
double SumOfCounts(int [] array)
{
    double sum = new double();
    for (int i = 0; i < array.Length; i+=2)
    {
        sum += array [i];
    }
    return sum;
}

Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [size];
CreateArray(arr);
ShowArray(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {SumOfCounts(arr)}");