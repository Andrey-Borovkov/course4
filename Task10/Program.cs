// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int GetMaxLetterOfNumber(int letter)
{
        int letter2 = (letter /10) % 10;
        return letter2;
}
int result = GetMaxLetterOfNumber(Number);
Console.WriteLine($"В веденном числе вторая цифра равна {result}");