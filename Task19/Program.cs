// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[5];
int index = 4;
if (number.ToString().Length != 5)
{
    Console.WriteLine("Вы ввели НЕ пятизначное число!");    
}
else
{
    for (int i = 1; i <= array.Length; i++)
    {
        array[index] = number % 10;
        number = number / 10;
        index--;
    }
    for (int i = 0; i <=1; i++)
    {
        if (array[i] != array[array.Length - 1 - i])
        {
            Console.WriteLine("Введенное пятизначное число НЕ является палиндромом");
            System.Environment.Exit(0);
        }
    }
    Console.WriteLine($"Введенное пятизначное число является палиндромом");
}

