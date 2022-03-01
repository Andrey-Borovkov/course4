Console.WriteLine("Введите три числа");

Console.Write("1: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("3: ");
int Number3 = Convert.ToInt32(Console.ReadLine());

int max = Number1;
if (Number2 > max) max = Number2;
if (Number3 > max) max = Number3;

Console.Write(max);
Console.Write(" является максимальным среди остальных чисел");
//Console.Write(max);