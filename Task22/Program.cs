Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    double result = Math.Pow(i, 2);
    Console.Write($"{result}, "); 
}
