/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

*/

int SumOfCount(int number)
{
    
    int result = 0;
    while (number > 0)
    {
       int ostatok = number % 10;
       result = result + ostatok;
       number = number / 10;
        
    }
    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfCount(num));