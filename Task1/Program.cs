int a = new int();
int b = new int();
Console.Write("Введите целое число A: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число B: ");
b = Convert.ToInt32(Console.ReadLine());

if (b * b == a)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго");
}