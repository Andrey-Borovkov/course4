/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int SumOfCount(int number)
{
    
    int result = 0;
    while (number > 0)
    {
       number = number % 10;
       result = result + number;
        
    }
    return result;
}
Console.WriteLine(SumOfCount(num));