/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
void CreateArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(1, 200);
    }
}

void ShowArray(int [] array)
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
int ElemetsInInterval(int [] array)
{
    int result = new int();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            result++;
        }
    }
    return result;
}


int [] arr = new int [128];
CreateArray(arr);
ShowArray(arr);
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] равно {ElemetsInInterval(arr)}");