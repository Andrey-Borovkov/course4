// Задача 14. Программа, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int GetNumber(int value)
{
    if ((value % 7 == 0) && (value % 23 == 0))
    {
        Console.WriteLine("Введенное число кратно одновременно 7 и 23");
    }
    else
    {
        Console.WriteLine("Введенное число НЕ кратно одновременно 7 и 23");
    }
    return value;
}
GetNumber(number);
