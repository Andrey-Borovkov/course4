/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
void CreateArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(-100, 101);
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

void NumberComparison(int [] array, int number)
{
    bool result = new bool();
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            result = true;
            break;
        }
    }
    if (result == true)
    {
        Console.WriteLine("Заданное число присутствует в массиве");
    }
    else
    {
        Console.WriteLine("Заданное число отсутствует в массиве");
    }
}

Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [size];
CreateArray(arr);
ShowArray(arr);
Console.Write("Введите заданное число: ");
int number = Convert.ToInt32(Console.ReadLine());
NumberComparison(arr, number);