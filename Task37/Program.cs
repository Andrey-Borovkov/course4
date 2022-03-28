/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 12 10
*/
void CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
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

void CreateNewArray(int[] array, int[] NewArray)
{
    if (array.Length % 2 == 0)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            NewArray[i] = array[i] * array[array.Length - 1 - i];
        }
    }
    else
    {
        for (int i = 0; i < (array.Length - 1) / 2; i++)
        {
            NewArray[i] = array[i] * array[array.Length - 1 - i];
        }
        NewArray[NewArray.Length - 1] = array[(array.Length - 1) / 2];
    }
}

Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
int lengthNewArray = new int();

if (arr.Length % 2 == 0)
{
    lengthNewArray = arr.Length / 2;
}
else
{
    lengthNewArray = (arr.Length + 1) / 2;
}

int[] NewArray = new int[lengthNewArray];
CreateArray(arr);
ShowArray(arr);
CreateNewArray(arr, NewArray);
ShowArray(NewArray);



