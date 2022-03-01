Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 2;
if (number >= 2) 
{
    while (index <= number)
    {
        Console.WriteLine(index);
        index = index + 2;
    }
}
else
{
    Console.WriteLine("Введенное число меньше 2");
}