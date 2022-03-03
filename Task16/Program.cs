// Задача 16. Является ли второе число квадратом первого.
Console.Write("Введите целое число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = a * a;
int Square(int value)
{
    if (value == b)
    {
        Console.WriteLine("Второе число является квадратом первого.");
    }
    else
    {
        Console.WriteLine("Второе число НЕ является квадратом первого.");
    }
    return value;
}
Square(result);

