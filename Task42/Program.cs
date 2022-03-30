/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
string ConvertToBin(int number)
{
    string binNumber = new string("");
    int reminder = new int();
    while (number > 1)
    {
        reminder = number % 2;
        number /=2;
        binNumber = binNumber.Insert(0, reminder.ToString());
    }
    binNumber = binNumber.Insert(0, number.ToString());
    return binNumber;
}

Console.WriteLine("Введите деситичное число: ");
int decNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат преобразования десятичного числа {decNumber} в двоичную форму - {ConvertToBin(decNumber)}");
