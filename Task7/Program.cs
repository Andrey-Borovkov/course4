int N = new int();
int max = new int();
int convert = new int();
Console.Write("Введите число N: ");
N = Convert.ToInt32(Console.ReadLine());
max = N;
convert = -N;
while (convert <= max) 
{
Console.Write(convert);
convert++;
}
