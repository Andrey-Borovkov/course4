/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
int NumbersGreatZero(int number)
{
    int[] array = new int[number];
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}

Console.WriteLine("Сколько чисел ввести с клавиатуры?");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Пользователь ввел {NumbersGreatZero(M)} числа (чисел) больше 0");
